using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class GMChangedMessage : ServerMessage
    {
        public bool IsGM;

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleGMChanged(this);
        }
    }
}
