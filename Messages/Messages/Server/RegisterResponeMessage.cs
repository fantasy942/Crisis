using System;

namespace Crisis.Messages.Server
{
    public enum RegisterResponse
    {
        Ok,
        NameTaken
    }

    [Serializable]
    public class RegisterResponeMessage : ServerMessage
    {
        public RegisterResponse Response;

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleRegisterResponse(this);
        }
    }
}
