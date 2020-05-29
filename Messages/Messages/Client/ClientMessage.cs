using System;

namespace Crisis.Messages.Client
{
    /// <summary>
    /// Represents a client to server message.
    /// </summary>
    [Serializable]
    public abstract class ClientMessage : Message
    {
        public abstract void Visit(IClientHandler visitor);
    }
}
