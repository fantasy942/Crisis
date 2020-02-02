using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crisis.Messages;
using Crisis.Network;

namespace Crisis
{
    class Character
    {
        private static readonly List<Character> characters = new List<Character>();
        public static IReadOnlyList<Character> Characters => characters;

        public string Name { get; set; }

        public Client Client { get; set; }
        
        public Character()
        {
            characters.Add(this);
        }

        public void Speak(string text)
        {
            foreach (var item in characters)
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
