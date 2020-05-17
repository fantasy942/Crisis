using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class RegisterMessage : ClientMessage
    {
        public string Mail;
        public string Password;

        public override void Visit(IClientVisitor visitor)
        {
            visitor.VisitRegister(this);
        }
    }
}
