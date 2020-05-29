using Crisis.Messages.Server;
using System.Collections.Generic;

namespace Crisis
{
    class Area
    {
        private readonly List<Room> rooms = new List<Room>();
        public IReadOnlyList<Room> Rooms => rooms;

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                foreach (var room in rooms)
                {
                    foreach (var character in room.Characters)
                    {
                        character.Client?.Send(RoomMessage.AreaRenamed(name));
                    }
                }
            }
        }

        public Area(string name)
        {
            Name = name;
        }

        public void Add(Room room)
        {
            rooms.Add(room);
        }

        public void Remove(Room room)
        {
            rooms.Remove(room);
        }

        public static Area Lobby { get; } = new Area("Lobby");
    }
}
