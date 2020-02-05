using System;
namespace Crisis.Messages.Server
{
    [Serializable]
    public class TimeTurnMessage : Message
    {
        public DateTime Time;
        public DateTime TurnEnd;
        public int Turn;
    }
}
