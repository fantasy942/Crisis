using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class AuthConfirmMessage : ServerMessage
    {
        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleAuthConfirm(this);
        }
    }
}
