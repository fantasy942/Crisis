using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class AuthMessage : ClientMessage
    {
        public string Mail { get; }
        public string Password { get; }

        public AuthMessage(string mail, string pwd)
        {
            Mail = mail;
            Password = pwd;
        }

        public override void Visit(IClientHandler visitor)
        {
            visitor.HandleAuth(this);
        }
    }
}
