namespace Crisis
{
    class Rank
    {
        public string Name { get; }

        public Rank(string name)
        {
            Name = name;
        }

        public static Rank Default { get; } = new Rank("Civilian");
    }
}
