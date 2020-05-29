using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class GMChangedMessage : ServerMessage
    {
        public bool IsGM { get; }

        public GMChangedMessage(bool isGm)
        {
            IsGM = isGm;
        }

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleGMChanged(this);
        }
    }
}
