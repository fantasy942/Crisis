using Crisis.Messages.Server;
using System;
using System.Collections.Generic;

namespace Crisis
{
    class Rank
    {
        private readonly List<Character> characters = new List<Character>();
        public IReadOnlyList<Character> Characters => characters;

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                foreach (var item in characters)
                {
                    item.Client?.Send(new CharacterMessage { Rank = name });
                }
            }
        }

        public static Rank Default { get; } = new Rank("Civilian");

        public Rank(string name)
        {
            Name = name;
        }

        public void Add(Character character)
        {
            characters.Add(character);
            character.Client?.Send(new CharacterMessage { Rank = Name });
        }

        public void Remove(Character character)
        {
            characters.Remove(character);
        }
    }
}