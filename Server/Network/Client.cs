using System;
using Crisis.Messages;
using Crisis.Messages.Client;
using Crisis.Messages.Server;
using Hyalus;

namespace Crisis.Network
{
    class Client : IClientHandler
    {
        private readonly Connection<Message> connection;

        private readonly Action<Connection<Message>> onDisconnect;

        /// <summary>
        /// While the client is not authed it can only receive auth and register messages, the rest will be dropped.
        /// </summary>
        public bool Authed { get; private set; } = false;
        public bool Connected { get; private set; } = true;
        public Character Character { get; private set; }
        public bool IsGm { get; private set; } = false;

        public Client(Connection<Message> connection, Action<Connection<Message>> onDisconnect)
        {
            this.connection = connection;
            this.onDisconnect = onDisconnect;
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
            connection.Disconnect();
            onDisconnect(connection);
        }

        public void Send(params ServerMessage[] msg)
        {
            connection.Send(msg);
        }

        public void Receive(ClientMessage msg)
        {
            if (!Connected) return;
            msg.Visit(this);
        }

        #region Message handling
        public void HandleAuth(AuthMessage msg)
        {
            if (Authed) //Someone tried to auth twice?
            {
                return;
            }

            Character = new Character(msg.Mail)
            {
                Client = this
            };

            Send(
                new AuthConfirmMessage(),
                new GMChangedMessage(true),
                new TimeTurnMessage(DateTime.UtcNow, DateTime.UtcNow.AddHours(1), 42),
                new CharacterMessage { Name = Character.Name, Rank = Character.Rank.Name, Branch = "???", Faction = "None", Ready = Character.Ready }
                );

            Character.Room = Room.Lobby;

            Authed = true;
        }

        public void HandleRegister(RegisterMessage msg)
        {
            Send(new RegisterResponeMessage(RegisterResponse.Ok)); //TODO: Get a db
        }

        public void HandleSpeech(SpeechMessage msg)
        {
            if (!Authed || msg.Text == null) return;
            Character.Speak(msg.Text);
        }

        public void HandleReady(ReadyMessage msg)
        {
            if (Character != null)
            {
                Character.Ready = msg.Ready;
                Send(new CharacterMessage { Ready = msg.Ready });
                foreach (var item in Character.Characters)
                {
                    item.Client?.Send(new ReadinessMessage(0, 79, 0, 99));
                }
            }
            else
            {
                Send(new CharacterMessage { Ready = false });
            }
        }
        #endregion
    }
}
