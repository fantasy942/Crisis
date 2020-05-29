using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class HearMessage : ServerMessage
    {
        public DateTime Time { get; }
        public string Rank { get; }
        public string Name { get; }
        public string Text { get; }

        public HearMessage(DateTime time, string rank, string name, string text)
        {
            Time = time;
            Rank = rank;
            Name = name;
            Text = text;
        }

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleHear(this);
        }
    }
}
