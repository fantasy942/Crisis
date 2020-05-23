using System;
using System.Threading.Tasks;
using Crisis.Messages;
using Crisis.Messages.Client;
using Crisis.Messages.Server;
using Hyalus;

namespace Crisis.Model
{
    public class CrisisModel : IServerVisitor
    {
        private readonly Client<Message> client = new Client<Message>(new MessageCommunicator());

        private bool lastAuthSucceeded = false;

        public delegate void HearDelegate(string name, string rank, string text, DateTime time);
        public delegate void TurnDelegate(DateTime time, DateTime turnend, int turn);

        public event HearDelegate OnHear;
        public event Action<bool> OnGmChanged;
        public event TurnDelegate OnTimeTurn;

        public async Task<ConnectAttemptResult> Connect(string ip, int port, ClientMessage startingMessage)
        {
            await client.ConnectAsync(ip, port);
            if (client.Connected)
            {
                client.Send(startingMessage);
                var response = (ServerMessage)await client.NextMessageAsync();
                response.Visit(this);
                if (lastAuthSucceeded)
                {
                    _ = ListeningLoopAsync();
                    return ConnectAttemptResult.Ok;
                }
                return ConnectAttemptResult.AuthFail;
            }
            else
            {
                return ConnectAttemptResult.GenericFail;
            }
        }

        public void Disconnect()
        {
            client.Disconnect();
        }

        public void Send(ClientMessage msg)
        {
            client.Send(msg);
        }

        private async Task ListeningLoopAsync()
        {
            bool disconnected = false;
            while (!disconnected)
            {
                var msg = (ServerMessage)await client.NextMessageAsync();
                msg.Visit(this);
            }
        }

        public void VisitAuthConfirm(AuthConfirmMessage msg)
        {
            lastAuthSucceeded = true;
        }

        public void VisitAuthDeny(AuthDenyMessage msg)
        {
            lastAuthSucceeded = false;
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
