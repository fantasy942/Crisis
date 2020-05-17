using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class AuthDenyMessage : ServerMessage
    {
        public override void Visit(IServerVisitor visitor)
        {
            visitor.VisitAuthDeny(this);
        }
    }
}
