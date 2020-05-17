using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class GMChangedMessage : ServerMessage
    {
        public bool IsGM;

        public override void Visit(IServerVisitor visitor)
        {
            visitor.VisitGMChanged(this);
        }
    }
}
