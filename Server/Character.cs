using System;
using System.Collections.Generic;
using System.Linq;
using Crisis.Messages.Server;
using Crisis.Network;

namespace Crisis
{
    class Character
    {
        private static readonly List<Character> characters = new List<Character>();
        public static IReadOnlyList<Character> Characters => characters;

        public string Name { get; set; }
        public Rank Rank { get; set; } = Rank.Default;
        public Faction Faction { get; set; }

        private Room room;
        public Room Room
        {
            get => room;
            set
            {
                room?.Leave(this);
                room = value;
                room?.Enter(this);
            }
        }

        public Client Client { get; set; }
        public bool Awake => Client != null && Client.Connected;
        
        public Character(string name)
        {
            characters.Add(this);
            Name = name;
        }

        public void Speak(string text)
        {
            foreach (var item in room?.Characters ?? Array.Empty<Character>())
            {
                item.Hear(Name, text);
            }
        }

        public void Hear(string source, string text)
        {
            Client?.Send(new HearMessage { Time = DateTime.Now, Rank = string.Empty , Name = source, Text = text });
        }
    }
}
