using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Crisis.Messages;
using Crisis.Messages.Client;
using Crisis.Messages.Server;
using Crisis.Persistence;
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
            clients.Add(this);
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
            clients.Remove(this);
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

            Character = Database.Context.Characters.SingleOrDefault(x => x.Name == msg.Mail);
            if (Character == null)
            {
                Character = new Character(msg.Mail, Room.Lobby, null);
                Database.Context.Characters.Add(Character);
            }
            Character.Client = this;
            Database.Context.SaveChanges();

            Send(
                new AuthConfirmMessage(),
                new GMChangedMessage(true),
                new TimeTurnMessage(DateTime.UtcNow, DateTime.UtcNow.AddHours(1), 42),
                new CharacterMessage { Name = Character.Name, /*Rank = Character.Rank.Name, */ Branch = "???", Faction = "None", Ready = Character.Ready },
                new AreaMessage(Character.Room.Area.Name, Database.Context.Rooms.Where(x => x.Area == Character.Room.Area).Select(x => x.Name).ToArray()),
                new RoomMessage(Character.Room.Name),
                new PeopleMessage(
                    PeopleMessageType.Override,
                    Database.Context.Characters.Where(x => x.Room == Character.Room).Select(x => x.Name).ToArray())
                );

            Database.Context.SaveChanges();

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
            }
            else
            {
                Send(new CharacterMessage { Ready = false });
            }
        }

        public void HandleRoom(RoomTravelMessage msg)
        {
            Character.Room = Database.Context.Rooms.SingleOrDefault(x => x.Area == Character.Room.Area && x.Name == msg.Room) ?? Character.Room;
        }

        public void HandleArea(AreaTravelMessage msg)
        {
            //TODO
        }
        #endregion

        private static readonly List<Client> clients = new List<Client>();
        public static IReadOnlyList<Client> Clients => clients;
    }
}
