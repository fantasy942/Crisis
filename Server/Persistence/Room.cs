using Crisis.Messages.Server;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Crisis.Persistence
{
    public class Room
    {
        [Key]
        [MaxLength(Database.NameLength)]
        public string Name { get; set; }
        public virtual Faction Faction { get; set; }
        [Required]
        public virtual Area Area { get; set; }

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

        public void Arrived(Character character)
        {
            foreach (var item in Database.Context.Characters.Where(x => x.Room.Name == Name && x != character))
            {
                item.Client?.Send(new PeopleMessage(PeopleMessageType.Arrived, new[] { character.Name }));
            }
        }

        public void Left(Character character)
        {
            foreach (var item in Database.Context.Characters.Where(x => x.Room.Name == Name && x != character))
            {
                item.Client?.Send(new PeopleMessage(PeopleMessageType.Left, new[] { character.Name }));
            }
        }
    }
}
