using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class AreaMessage : ServerMessage
    {
        public string Area { get; }
        public string[] Rooms { get; }

        public AreaMessage(string area, string[] rooms)
        {
            Area = area;
            Rooms = rooms;
        }

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleArea(this);
        }
    }
}
