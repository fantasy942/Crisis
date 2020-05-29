using System;
namespace Crisis.Messages.Server
{
    [Serializable]
    public class TimeTurnMessage : ServerMessage
    {
        public DateTime Time { get; }
        public DateTime TurnEnd { get; }
        public int Turn { get; }

        public TimeTurnMessage(DateTime time, DateTime turnend, int turn)
        {
            Time = time;
            TurnEnd = turnend;
            Turn = turn;
        }

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleTimeTurn(this);
        }
    }
}
