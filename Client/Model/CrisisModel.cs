using System;
using System.Threading.Tasks;
using Crisis.Messages.Client;
using Crisis.Messages.Server;
using Telepathy;

namespace Crisis.Model
{
    public class CrisisModel : IServerVisitor
    {
        private readonly Telepathy.Client client = new Telepathy.Client();
        private TaskCompletionSource<ConnectAttemptResult> ConnectResult;

        public delegate void HearDelegate(string name, string rank, string text, DateTime time);
        public delegate void TurnDelegate(DateTime time, DateTime turnend, int turn);

        public event HearDelegate OnHear;
        public event Action<bool> OnGmChanged;
        public event TurnDelegate OnTimeTurn;
        public event Action Disconnected;

        public Task<ConnectAttemptResult> Connect(string ip, int port, ClientMessage startingMessage)
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

        public void Send(ClientMessage msg)
        {
            client.Send(msg.Serialize());
        }

        private async Task ListeningLoopAsync(ClientMessage startingMessage)
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
                            case EventType.Connected:
                                if (startingMessage != null)
                                {
                                    Send(startingMessage);
                                }
                                break;
                            case EventType.Data:
                                if (Messages.Message.TryInfer(msg.data, out ServerMessage inferred))
                                {
                                    Receive(inferred);
                                }
                                break;
                            case EventType.Disconnected:
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

        private void Receive(ServerMessage msg)
        {
            msg.Visit(this);
        }

        public void VisitAuthConfirm(AuthConfirmMessage msg)
        {
            ConnectResult.TrySetResult(ConnectAttemptResult.Ok);
        }

        public void VisitAuthDeny(AuthDenyMessage msg)
        {
            ConnectResult.TrySetResult(ConnectAttemptResult.AuthFail);
        }

        public void VisitGMChanged(GMChangedMessage msg)
        {
            OnGmChanged?.Invoke(msg.IsGM);
        }

        public void VisitHear(HearMessage msg)
        {
            OnHear?.Invoke(msg.Name, msg.Rank, msg.Text, msg.Time);
        }

        public void VisitRegisterResponse(RegisterResponeMessage msg)
        {
            throw new NotImplementedException();
        }

        public void VisitTimeTurn(TimeTurnMessage msg)
        {
            OnTimeTurn?.Invoke(msg.Time, msg.TurnEnd, msg.Turn);
        }
    }
}
