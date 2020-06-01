using System.ComponentModel.DataAnnotations;

namespace Crisis.Persistence
{
    public class Faction
    {
        [Key]
        [MaxLength(Database.NameLength)]
        public string Name { get; set; }
    }
}
