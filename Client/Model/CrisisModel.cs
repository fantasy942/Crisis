using System;
using System.Threading.Tasks;
using Crisis.Messages;
using Crisis.Messages.Client;
using Crisis.Messages.Server;
using Hyalus;

namespace Crisis.Model
{
    public class CrisisModel : IServerHandler
    {
        private readonly Client<Message> client = new Client<Message>(new MessageCommunicator());

        private bool lastAuthSucceeded = false;

        public delegate void HearDelegate(string name, string rank, string text, DateTime time);
        public delegate void TurnDelegate(DateTime time, DateTime turnend, int turn);
        public delegate void CharacterDelegate(string name, string rank, string branch, string faction, bool? ready);
        public delegate void ReadinessDelegate(byte staffready, byte staffneeded, byte headsready, byte headsneeded);
        public delegate void RoomDelegate(string name);
        public delegate void AreaDelegate(string name, string[] rooms);
        public delegate void PeopleOverrideDelegate(string[] people);
        public delegate void PeopleArrivedDelegate(string[] people);
        public delegate void PeopleLeftDelegate(string[] people);

        public event HearDelegate OnHear;
        public event Action<bool> OnGmChanged;
        public event TurnDelegate OnTimeTurn;
        public event CharacterDelegate OnCharacterChanged;
        public event ReadinessDelegate OnReadinessUpdated;
        public event RoomDelegate OnRoomChanged;
        public event AreaDelegate OnAreaChanged;
        public event PeopleOverrideDelegate OnPeopleOverride;
        public event PeopleArrivedDelegate OnPeopleArrive;
        public event PeopleLeftDelegate OnPeopleLeave;

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

        #region Message handling
        public void HandleAuthConfirm(AuthConfirmMessage msg)
        {
            lastAuthSucceeded = true;
        }

        public void HandleAuthDeny(AuthDenyMessage msg)
        {
            lastAuthSucceeded = false;
        }

        public void HandleGMChanged(GMChangedMessage msg)
        {
            OnGmChanged?.Invoke(msg.IsGM);
        }

        public void HandleHear(HearMessage msg)
        {
            OnHear?.Invoke(msg.Name, msg.Rank, msg.Text, msg.Time);
        }

        public void HandleRegisterResponse(RegisterResponeMessage msg)
        {
            throw new NotImplementedException();
        }

        public void HandleTimeTurn(TimeTurnMessage msg)
        {
            OnTimeTurn?.Invoke(msg.Time, msg.TurnEnd, msg.Turn);
        }

        public void HandleCharacter(CharacterMessage msg)
        {
            OnCharacterChanged?.Invoke(msg.Name, msg.Rank, msg.Branch, msg.Faction, msg.Ready);
        }

        public void HandleReadiness(ReadinessMessage msg)
        {
            OnReadinessUpdated?.Invoke(msg.StaffReady, msg.StaffNeeded, msg.HeadsReady, msg.HeadsNeeded);
        }

        public void HandleRoom(RoomMessage msg)
        {
            OnRoomChanged?.Invoke(msg.Room);
        }

        public void HandleArea(AreaMessage msg)
        {
            OnAreaChanged?.Invoke(msg.Area, msg.Rooms);
        }

        public void HandlePeople(PeopleMessage msg)
        {
            switch (msg.Type)
            {
                case PeopleMessageType.Override:
                    OnPeopleOverride?.Invoke(msg.People);
                    break;
                case PeopleMessageType.Arrived:
                    OnPeopleArrive?.Invoke(msg.People);
                    break;
                case PeopleMessageType.Left:
                    OnPeopleLeave?.Invoke(msg.People);
                    break;
            }
        }
        #endregion
    }
}
