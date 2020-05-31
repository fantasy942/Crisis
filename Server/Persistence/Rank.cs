using Crisis.Messages.Server;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Crisis.Persistence
{
    class Rank
    {
        private string _name;
        [Key]
        [MaxLength(Database.NameLength)]
        public string Name
        {
            get => _name;
            set
            {
                foreach (var item in Database.Context.Characters.Where(x => x.Rank != null && x.Rank.Name == _name))
                {
                    item.Client?.Send(new CharacterMessage { Rank = value });
                }
                _name = value;
            }
        }

        private Faction _faction;
        public Faction Faction
        {
            get => _faction;
            set
            {
                foreach (var item in Database.Context.Characters.Where(x => x.Rank == this))
                {
                    item.Client?.Send(new CharacterMessage { Faction = value.Name });
                }
                _faction = value;
            }
        }
    }
}