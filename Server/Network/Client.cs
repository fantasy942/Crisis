﻿using System;
using Crisis.Messages;
using Crisis.Messages.Client;
using Crisis.Messages.Server;
using Hyalus;

namespace Crisis.Network
{
    class Client : IClientVisitor
    {
        public Connection<Message> Connection { get; }
        /// <summary>
        /// While the client is not authed it can only receive auth and register messages, the rest will be dropped.
        /// </summary>
        public bool Authed { get; private set; } = false;
        public bool Connected { get; private set; } = true;
        public Character Character { get; private set; }
        public bool IsGm { get; private set; } = false;

        public Client(Connection<Message> connection)
        {
            Connection = connection;
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
            Connection.Disconnect();
        }

        public void Send(ServerMessage msg)
        {
            Connection.Send(msg);
        }

        public void Receive(ClientMessage msg)
        {
            if (!Connected) return;
            msg.Visit(this);
        }

        public void VisitAuth(AuthMessage msg)
        {
            if (Authed) //Someone tried to auth twice?
            {
                return;
            }

            Character = new Character
            {
                Client = this,
                Name = msg.Mail
            };
            Send(new AuthConfirmMessage());
            Send(new GMChangedMessage { IsGM = true });
            Send(new TimeTurnMessage { Time = DateTime.UtcNow, TurnEnd = DateTime.UtcNow.AddHours(1) });
            Authed = true;
        }

        public void VisitRegister(RegisterMessage msg)
        {
            Send(new RegisterResponeMessage { Response = RegisterResponse.Ok }); //TODO: Get a db
        }

        public void VisitSpeech(SpeechMessage msg)
        {
            if (!Authed) return;
            Character.Speak(msg.Text);
        }
    }
}
