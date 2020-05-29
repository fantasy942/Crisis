using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class RegisterMessage : ClientMessage
    {
        public string Mail { get; }
        public string Password { get; }

        public RegisterMessage(string mail, string pwd)
        {
            Mail = mail;
            Password = pwd;
        }

        public override void Visit(IClientHandler visitor)
        {
            visitor.HandleRegister(this);
        }
    }
}
