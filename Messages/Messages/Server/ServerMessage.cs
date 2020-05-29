using System;

namespace Crisis.Messages.Server
{
    /// <summary>
    /// Represents a server to client message.
    /// </summary>
    [Serializable]
    public abstract class ServerMessage : Message
    {
        public abstract void Visit(IServerHandler visitor);
    }
}
