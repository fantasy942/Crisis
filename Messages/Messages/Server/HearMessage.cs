using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class HearMessage : Message
    {
        public DateTime Time;
        public string Rank;
        public string Name;
        public string Text;
    }
}
