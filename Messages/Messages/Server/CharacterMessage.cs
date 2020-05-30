using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class CharacterMessage : ServerMessage
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Branch { get; set; }
        public string Faction { get; set; }
        public bool? Ready { get; set; }

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleCharacter(this);
        }
    }
}
