using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Crisis.Messages.Server;
using Crisis.Network;
using Microsoft.EntityFrameworkCore;

namespace Crisis.Persistence
{
    class Character
    {
        private string _name;
        [Key]
        [MaxLength(Database.NameLength)]
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Client?.Send(new CharacterMessage { Name = _name });
                Database.Context.SaveChanges();
            }
        }

        public bool Ready { get; set; } = false;

        private Rank _rank;
        public Rank Rank
        {
            get => _rank;
            set
            {
                _rank = value;
                Client?.Send(new CharacterMessage { Rank = _rank.Name });
                Database.Context.SaveChanges();
            }
        }

        private Room _room;
        public Room Room
        {
            get => _room;
            set
            {
                var old = _room;
                _room = value;
                Database.Context.SaveChanges();
                Client?.Send(RoomMessage.AreaChanged(value?.Area.Name ?? "Unknown", value?.Name ?? "Nowhere",
                    Database.Context.Characters.Where(x => x.Room == value).Select(x => x.Name).ToArray()));
                value.UpdatePeople();
                old?.UpdatePeople();
            }
        }

        public Faction Faction => Rank?.Faction;

        [NotMapped]
        public Client Client { get; set; }

        public void Speak(string text)
        {
            foreach (var item in Database.Context.Characters.Where(x => x.Room == Room))
            {
                item.Hear(this, text);
            }
        }

        public void Hear(Character source, string text)
        {
            Client?.Send(new HearMessage(DateTime.Now, source.Rank?.Name, source.Name, text));
        }
    }
}
