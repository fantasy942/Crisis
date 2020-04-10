using System;
using Crisis.Messages;
using Crisis.Messages.Client;
using Crisis.Messages.Server;

namespace Crisis.Network
{
    class Client
    {
        public int ID { get; }
        /// <summary>
        /// While the client is not authed it can only receive auth and register messages, the rest will be dropped.
        /// </summary>
        public bool Authed { get; private set; }
        public bool Connected { get; private set; } = true;
        public Character Character { get; private set; }
        public bool IsGm { get; private set; }

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
                    Name = authmsg.Mail
                };
                Send(new AuthConfirmMessage());
                Send(new GMChangedMessage { IsGM = true });
                Send(new TimeTurnMessage { Time = DateTime.UtcNow, TurnEnd = DateTime.UtcNow.AddHours(1) });
                Authed = true;
                return;
            }
            else if (msg is RegisterMessage)
            {
                Send(new RegisterResponeMessage { Response = RegisterResponse.Ok }); //TODO: Get a db
            }

            if (!Authed) return;

            if (msg is SpeechMessage speechmsg)
            {
                Character.Speak(speechmsg.Text);
            }
            else if (IsGm)
            {

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
