using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Crisis.Persistence
{
    class Area
    {
        [Key]
        [MaxLength(Database.NameLength)]
        public string Name { get; set; }
        public Faction Faction { get; set; }

        public static Area Lobby
        {
            get
            {
                const string lobname = "Lobby";
                var lobby = Database.Context.Areas.SingleOrDefault(x => x.Name == lobname);
                if (lobby == null)
                {
                    lobby = new Area { Name = "Lobby" };
                    Database.Context.Areas.Add(lobby);
                }
                return lobby;
            }
        }
    }
}
