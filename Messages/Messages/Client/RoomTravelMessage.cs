using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class RoomTravelMessage : ClientMessage
    {
        public string Room { get; }

        public RoomTravelMessage(string room)
        {
            Room = room;
        }

        public override void Visit(IClientHandler visitor)
        {
            visitor.HandleRoom(this);
        }
    }
}
