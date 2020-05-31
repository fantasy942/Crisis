namespace Crisis.Persistence
{
    static class Database
    {
        public const int NameLength = 100;
        public static readonly CrisisDatabaseContext Context = new CrisisDatabaseContext();
    }
}
