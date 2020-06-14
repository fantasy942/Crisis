using Crisis.Messages.Server;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Crisis.Persistence
{
    public class Rank
    {
        private string _name;
        [Key]
        public string Name
        {
            get => _name;
            set
            {
                foreach (var item in Database.Game.Characters.IncLocal(y => y.Where(x => x.Rank != null && x.Rank.Name == _name)))
                {
                    item.Client?.EnqueueMessages(new CharacterMessage { Rank = value });
                }
                _name = value;
            }
        }

        private Faction _faction;
        public virtual Faction Faction
        {
            get => _faction;
            set
            {
                foreach (var item in Database.Game.Characters.IncLocal(y => y.Where(x => x.Rank.Name == Name)))
                {
                    item.Client?.EnqueueMessages(new CharacterMessage { Faction = value.Name });
                }
                _faction = value;
            }
        }
    }
}