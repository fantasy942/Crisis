using Crisis.Messages.Server;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crisis
{
    class Room
    {
        public string Name { get; set; }
        public Faction Faction { get; set; }

        private readonly List<Character> characters = new List<Character>();
        public IReadOnlyList<Character> Characters => characters;

        public static Room Lobby { get; } = new Room { Name = "Lobby" };

        public void Enter(Character character)
        {
            characters.Add(character);
            foreach (var item in characters)
            {
                item.Client?.Send(new RoomMessage
                {
                    Name = Name,
                    People = characters.Select(x => x.Name).ToArray() ?? Array.Empty<string>()
                });
            }
        }

        public void Leave(Character character)
        {
            characters.Remove(character);
        }
    }
}
