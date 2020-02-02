using System;

namespace Crisis.Messages
{
    [Serializable]
    public class HearMessage : ServerMessage
    {
        public DateTime Time;
        public string Rank;
        public string Name;
        public string Text;
    }
}
