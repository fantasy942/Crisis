using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class RegisterMessage : Message
    {
        public string Mail;
        public string Password;
    }
}
