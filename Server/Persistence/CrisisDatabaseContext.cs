using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Crisis.Persistence
{
    class CrisisDatabaseContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Rank> Ranks { get; set; }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Faction> Factions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Configuration.DatabasePath));
            optionsBuilder.UseSqlite($"Data Source={Configuration.DatabasePath}");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
