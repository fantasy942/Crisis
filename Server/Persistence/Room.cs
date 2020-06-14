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
        public string Name { get; set; }
        public virtual Faction Faction { get; set; }
        [Required]
        public virtual Area Area { get; set; }

        public Room() { }

        public Room(string name, Area area)
        {
            Name = name;
            Area = area;
        }

        public static Room Lobby
        {
            get
            {
                const string lobname = "Lobby";
                var lobby = Database.Game.Rooms.IncLocal(y => y.Where(x => x.Name == lobname)).SingleOrDefault();
                if (lobby == null)
                {
                    lobby = new Room { Name = lobname, Area = Area.Lobby };
                }
                return lobby;
            }
        }

        public void Arrived(Character character)
        {
            foreach (var item in Database.Game.Characters.IncLocal(y => y.Where(x => x.Room.Name == Name && x.Name != character.Name)))
            {
                item.Client?.EnqueueMessages(new PeopleMessage(PeopleMessageType.Arrived, new[] { character.Name }));
            }
        }

        public void Left(Character character)
        {
            foreach (var item in Database.Game.Characters.IncLocal(y => y.Where(x => x.Room.Name == Name && x.Name != character.Name)))
            {
                item.Client?.EnqueueMessages(new PeopleMessage(PeopleMessageType.Left, new[] { character.Name }));
            }
        }
    }
}
