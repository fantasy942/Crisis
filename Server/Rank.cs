using System;

namespace Crisis
{
    class Rank
    {
        public event Action NameChanged;

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                NameChanged?.Invoke();
            }
        }

        public Rank(string name)
        {
            Name = name;
        }

        public static Rank Default { get; } = new Rank("Civilian");
    }
}