using System;

namespace Crisis.Messages.Server
{
    public enum RegisterResponse
    {
        Ok,
        NameTaken
    }

    [Serializable]
    public class RegisterResponeMessage : Message
    {
        public RegisterResponse Response;
    }
}
