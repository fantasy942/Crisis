using Crisis.Messages.Server;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crisis
{
    class Room
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                foreach (var item in characters)
                {
                    item.Client?.Send(RoomMessage.RoomRenamed(name));
                }
            }
        }
        public Faction Faction { get; set; }
        public Area Area { get; }

        private readonly List<Character> characters = new List<Character>();
        public IReadOnlyList<Character> Characters => characters;

        public static Room Lobby { get; } = new Room(Area.Lobby) { Name = "Lobby" };

        public Room(Area area)
        {
            Area = area;
            area.Add(this);
        }

        public void Enter(Character character)
        {
            characters.Add(character);
            UpdatePeople();
        }

        public void Leave(Character character)
        {
            characters.Remove(character);
            UpdatePeople();
        }

        private void UpdatePeople()
        {
            foreach (var item in characters)
            {
                item.Client?.Send(RoomMessage.PeopleChanged(characters.Select(x => x.Name).ToArray() ?? Array.Empty<string>()));
            }
        }
    }
}
