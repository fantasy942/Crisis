using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class RegisterMessage : ClientMessage
    {
        public string Mail;
        public string Password;

        public override void Visit(IClientHandler visitor)
        {
            visitor.HandleRegister(this);
        }
    }
}
