using System;
using System.Collections.Generic;
using System.Linq;
using Crisis.Messages.Server;
using Crisis.Network;
using Crisis.Ranks;

namespace Crisis
{
    class Character
    {
        private static readonly List<Character> characters = new List<Character>();
        public static IReadOnlyList<Character> Characters => characters;

        public bool Ready { get; set; } = false;

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                Client?.Send(new CharacterMessage { Name = name });
            }
        }

        private Rank rank = Rank.Default;
        public Rank Rank
        {
            get => rank;
            set
            {
                rank.Remove(this);
                rank = value ?? Rank.Default;
                rank.Add(this);
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
                Client?.Send(RoomMessage.AreaChanged(room.Area.Name, room.Name, room.Characters.Select(x => x.name).ToArray()));
                if (room == null)
                {
                    Client?.Send(RoomMessage.AreaChanged("Nowhere", "Unknown", Array.Empty<string>()));
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
            Client?.Send(new HearMessage(DateTime.Now, rank.Name, source, text));
        }
    }
}
