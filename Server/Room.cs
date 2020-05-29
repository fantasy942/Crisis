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
                Update();
            }
        }
        public Faction Faction { get; set; }

        private readonly List<Character> characters = new List<Character>();
        public IReadOnlyList<Character> Characters => characters;

        public static Room Lobby { get; } = new Room { Name = "Lobby" };

        public void Enter(Character character)
        {
            characters.Add(character);
            Update();
        }

        public void Leave(Character character)
        {
            characters.Remove(character);
            Update();
        }

        private void Update()
        {
            foreach (var item in characters)
            {
                item.Client?.Send(new RoomMessage
                {
                    Name = Name,
                    People = characters.Select(x => x.Name).ToArray() ?? Array.Empty<string>()
                });
            }
        }
    }
}
