using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class HearMessage : ServerMessage
    {
        public DateTime Time;
        public string Rank;
        public string Name;
        public string Text;

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleHear(this);
        }
    }
}
