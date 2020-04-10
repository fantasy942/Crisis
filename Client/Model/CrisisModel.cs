using System;
using System.Threading.Tasks;
using Crisis.Messages;
using Crisis.Messages.Server;

namespace Crisis.Model
{
    public class CrisisModel
    {
        private readonly Telepathy.Client client = new Telepathy.Client();
        private TaskCompletionSource<ConnectAttemptResult> ConnectResult;

        public event Action<Message> MessageArrived;
        public event Action Disconnected;

        public Task<ConnectAttemptResult> Connect(string ip, int port, Message startingMessage)
        {
            client.Connect(ip, port);
            _ = ListeningLoopAsync(startingMessage);
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

        private async Task ListeningLoopAsync(Message startingMessage)
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
                                if (startingMessage != null)
                                {
                                    Send(startingMessage);
                                }
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
                                Disconnected?.Invoke();
                                break;
                        }
                    }
                    await Task.Delay(1);
                }
                catch { }
            }
        }

        private void Receive(Message msg)
        {
            if (msg is AuthDenyMessage)
            {
                ConnectResult.TrySetResult(ConnectAttemptResult.AuthFail);
            }
            else if (msg is AuthConfirmMessage)
            {
                ConnectResult.TrySetResult(ConnectAttemptResult.Ok);
            }

            MessageArrived?.Invoke(msg);
        }
    }
}
