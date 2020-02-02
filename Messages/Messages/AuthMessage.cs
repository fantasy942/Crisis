using System;

namespace Crisis.Messages
{
    [Serializable]
    public class AuthMessage : ClientMessage
    {
        public string Username;
        public string Password;
    }
}
