using System.Collections.Concurrent;
using System.Threading.Tasks;
using Crisis.Messages;
using Crisis.Messages.Client;
using Crisis.Messages.Server;

namespace Crisis.Model
{
    public class CrisisModel
    {
        private readonly Telepathy.Client client = new Telepathy.Client();
        private readonly ConcurrentQueue<Message> msgs = new ConcurrentQueue<Message>();
        private AuthMessage authMessage; //We store credentials in case we have to reconnect on our own.
        private TaskCompletionSource<ConnectAttemptResult> ConnectResult;

        public Task<ConnectAttemptResult> Connect(string ip, int port, string username, string password)
        {
            client.Connect(ip, port);
            authMessage = new AuthMessage { Username = username, Password = password };
            Task.Run(ListeningLoop);
            ConnectResult = new TaskCompletionSource<ConnectAttemptResult>();
            return ConnectResult.Task;
        }

        public void Disconnect()
        {
            client.Disconnect();
        }

        public void Send(Message msg)
        {
            client.Send(msg.Serialize());
        }

        public bool TryPopMessage(out Message msg)
        {
            return msgs.TryDequeue(out msg);
        }

        private void ListeningLoop()
        {
            bool disconnected = false;
            while (!disconnected)
            {
                try
                {
                    while (client.GetNextMessage(out Telepathy.Message msg))
                    {
                        switch (msg.eventType)
                        {
                            case Telepathy.EventType.Connected:
                                //We have finally connected. Tell the server who we are.
                                client.Send(authMessage.Serialize());
                                break;
                            case Telepathy.EventType.Data:
                                if (Message.TryInfer(msg.data, out Message inferred))
                                {
                                    Receive(inferred);
                                }
                                break;
                            case Telepathy.EventType.Disconnected:
                                ConnectResult.TrySetResult(ConnectAttemptResult.GenericFail);
                                disconnected = true;
                                break;
                        }
                    }
                }
                catch { }
            }
        }

        private void Receive(Message msg)
        {
            msgs.Enqueue(msg);

            if (msg is AuthDenyMessage)
            {
                ConnectResult.TrySetResult(ConnectAttemptResult.AuthFail);
            }
            else if (msg is AuthConfirmMessage)
            {
                ConnectResult.TrySetResult(ConnectAttemptResult.Ok);
            }
        }
    }
}
