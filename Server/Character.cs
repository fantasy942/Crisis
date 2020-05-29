using System;
using System.Collections.Generic;
using Crisis.Messages.Server;
using Crisis.Network;

namespace Crisis
{
    class Character
    {
        private static readonly List<Character> characters = new List<Character>();
        public static IReadOnlyList<Character> Characters => characters;

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

        private Rank rank = Rank.Default;
        public Rank Rank
        {
            get => rank;
            set
            {
                if (rank != null) rank.NameChanged -= Update;
                rank = value;
                rank.NameChanged += Update;
                Update();
            }
        }

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
                if (room == null)
                {
                    Client?.Send(new RoomMessage { Name = "Unknown", People = Array.Empty<string>() });
                }
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

        private void Update()
        {
            Client?.Send(new CharacterMessage { Name = name, Rank = rank.Name, Branch = "???", Faction = "None" });
        }
    }
}
