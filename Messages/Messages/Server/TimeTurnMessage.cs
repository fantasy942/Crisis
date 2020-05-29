using System;
namespace Crisis.Messages.Server
{
    [Serializable]
    public class TimeTurnMessage : ServerMessage
    {
        public DateTime Time;
        public DateTime TurnEnd;
        public int Turn;

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleTimeTurn(this);
        }
    }
}
