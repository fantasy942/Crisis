﻿using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class RoomMessage : ServerMessage
    {
        public string Room { get; }

        public RoomMessage(string room)
        {
            Room = room;
        }

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleRoom(this);
        }
    }
}
