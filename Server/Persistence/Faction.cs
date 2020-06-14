using System.ComponentModel.DataAnnotations;

namespace Crisis.Persistence
{
    public class Faction
    {
        [Key]
        public string Name { get; set; }
    }
}
