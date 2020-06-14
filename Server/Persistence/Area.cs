using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Crisis.Persistence
{
    public class Area
    {
        [Key]
        public string Name { get; set; }
        public virtual Faction Faction { get; set; }

        public Area() { }

        public Area(string name)
        {
            Name = name;
            Database.Game.Areas.Add(this);
        }

        public static Area Lobby
        {
            get
            {
                const string lobname = "Lobby";
                var lobby = Database.Game.Areas.IncLocal(y => y.Where(x => x.Name == lobname)).SingleOrDefault();
                if (lobby == null)
                {
                    lobby = new Area("Lobby");
                }
                return lobby;
            }
        }
    }
}
