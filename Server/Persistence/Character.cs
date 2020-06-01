using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Crisis.Messages.Server;
using Crisis.Network;

namespace Crisis.Persistence
{
    public class Character
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

        private bool _ready = false;
        public bool Ready
        {
            get => _ready;
            set
            {
                _ready = value;
                Client?.Send(new CharacterMessage { Ready = _ready });
                Database.Context.SaveChanges();
                foreach (var item in Client.Clients)
                {
                    item.Send(new ReadinessMessage(0, 79, 0, 99));
                }
            }
        }

        private Rank _rank;
        public virtual Rank Rank
        {
            get => _rank;
            set
            {
                if (_rank == value) return;
                _rank = value;
                Client?.Send(new CharacterMessage { Rank = _rank.Name });
                Database.Context.SaveChanges();
            }
        }

        private Room _room;
        public virtual Room Room
        {
            get => _room;
            set
            {
                if (_room == value) return;

                var old = _room;
                _room = value;
                Database.Context.SaveChanges();
                
                Client?.Send(
                    new AreaMessage(Room.Area.Name, Database.Context.Rooms.Where(x => x.Area == Room.Area).Select(x => x.Name).ToArray()),
                    new RoomMessage(value.Name),
                    new PeopleMessage(
                        PeopleMessageType.Override,
                        Database.Context.Characters.Where(x => x.Room == _room).Select(x => x.Name).ToArray())
                    );
                value.Arrived(this);
                old.Left(this);
            }
        }

        public Faction Faction => Rank?.Faction;

        [NotMapped]
        internal Client Client { get; set; }

        public Character() { }

        public Character(string name, Room room, Rank rank)
        {
            _name = name;
            _room = room;
            _rank = rank;
        }

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
