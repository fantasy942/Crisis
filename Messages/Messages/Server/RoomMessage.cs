using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class RoomMessage : ServerMessage
    {
        public string Area { get; }
        public string Room { get; }
        public string[] People { get; }

        private RoomMessage(string area, string room, string[] people)
        {
            Area = area;
            Room = room;
            People = people;
        }

        public static RoomMessage AreaChanged(string area, string room, string[] people)
        {
            return new RoomMessage(area, room, people);
        }

        public static RoomMessage RoomChanged(string room, string[] people)
        {
            return new RoomMessage(null, room, people);
        }

        public static RoomMessage PeopleChanged(string[] people)
        {
            return new RoomMessage(null, null, people);
        }

        public static RoomMessage RoomRenamed(string room)
        {
            return new RoomMessage(null, room, null);
        }

        public static RoomMessage AreaRenamed(string area)
        {
            return new RoomMessage(area, null, null);
        }

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleRoom(this);
        }
    }
}
