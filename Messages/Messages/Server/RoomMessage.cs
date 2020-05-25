using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class RoomMessage : ServerMessage
    {
        public string Name;
        public string[] People;

        public override void Visit(IServerVisitor visitor)
        {
            visitor.VisitRoom(this);
        }
    }
}
