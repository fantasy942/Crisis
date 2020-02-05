using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class AuthMessage : Message
    {
        public string Mail;
        public string Password;
    }
}
