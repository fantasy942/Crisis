using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class AuthMessage : ClientMessage
    {
        public string Mail;
        public string Password;

        public override void Visit(IClientHandler visitor)
        {
            visitor.HandleAuth(this);
        }
    }
}
