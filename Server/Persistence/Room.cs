using Crisis.Messages.Server;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Crisis.Persistence
{
    class Room
    {
        [Key]
        [MaxLength(Database.NameLength)]
        public string Name { get; set; }
        public Faction Faction { get; set; }
        [Required]
        public Area Area { get; set; }

        public static Room Lobby
        {
            get
            {
                const string lobname = "Lobby";
                var lobby = Database.Context.Rooms.Include(x => x.Area).SingleOrDefault(x => x.Name == lobname);
                if (lobby == null)
                {
                    lobby = new Room { Name = lobname, Area = Area.Lobby };
                    Database.Context.Rooms.Add(lobby);
                    Database.Context.SaveChanges();
                }
                return lobby;
            }
        }

        public void UpdatePeople()
        {
            var people = Database.Context.Characters.Where(x => x.Room == this).ToArray();
            foreach (var item in people)
            {
                item.Client?.Send(RoomMessage.PeopleChanged(people.Select(x => x.Name).ToArray()));
            }
        }
    }
}
