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
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Client?.EnqueueMessages(new CharacterMessage { Name = _name });
            }
        }

        private bool _ready = false;
        public bool Ready
        {
            get => _ready;
            set
            {
                _ready = value;
                Client?.EnqueueMessages(new CharacterMessage { Ready = _ready });
                foreach (var item in Client.Clients)
                {
                    item.EnqueueMessages(new ReadinessMessage(0, 79, 0, 99));
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
                Client?.EnqueueMessages(new CharacterMessage { Rank = _rank.Name });
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
                
                Client?.EnqueueMessages(
                    new AreaMessage(Room.Area.Name, Database.Game.Rooms.IncLocal(y => y.Where(x => x.Area == Room.Area)).Select(x => x.Name).ToArray()),
                    new RoomMessage(value.Name),
                    new PeopleMessage(
                        PeopleMessageType.Override,
                        Database.Game.Characters.IncLocal(y => y.Where(x => x.Room == _room)).Select(x => x.Name).ToArray())
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
            Database.Game.Characters.Add(this);
        }

        public void Speak(string text)
        {
            foreach (var item in Database.Game.Characters.IncLocal(x => x.Where(y => y.Room == Room)))
            {
                item.Hear(this, text);
            }
        }

        public void Hear(Character source, string text)
        {
            Client?.EnqueueMessages(new HearMessage(DateTime.Now, source.Rank?.Name, source.Name, text));
        }
    }
}
