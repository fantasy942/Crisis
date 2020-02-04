using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class AuthMessage : Message
    {
        public string Username;
        public string Password;
    }
}
