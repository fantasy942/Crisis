using Crisis.Messages;

namespace Crisis.Network
{
    class Client
    {
        public int ID { get; }
        /// <summary>
        /// While the client is not authed it can only receive auth messages, the rest will be dropped.
        /// </summary>
        public bool Authed { get; private set; }
        public bool Connected { get; private set; } = true;
        public Character Character { get; private set; }

        public Client(int id)
        {
            ID = id;
        }

        public void Receive(Message msg)
        {
            if (!Connected) return;

            if (msg is AuthMessage authmsg)
            {
                if (Authed) //Someone tried to auth twice?
                {
                    return;
                }
                Character = new Character
                {
                    Client = this,
                    Name = authmsg.Username
                };
                Send(new AuthConfirmMessage());
                Authed = true;
                return;
            }

            if (!Authed) return;

            if (msg is SpeechMessage speechmsg)
            {
                Character.Speak(speechmsg.Text);
            }
        }

        public void Send(Message msg)
        {
            Server.Send(this, msg);
        }

        public void Disconnect()
        {
            if (!Connected)
            {
                return;
            }
            Connected = false;

            if (Character != null)
            {
                Character.Client = null;
                Character = null;
            }
            Server.Disconnect(this);
        }
    }
}
