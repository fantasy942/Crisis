using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class CharacterMessage : ServerMessage
    {
        public string Name;
        public string Rank;
        public string Branch;
        public string Faction;

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleCharacter(this);
        }
    }
}
