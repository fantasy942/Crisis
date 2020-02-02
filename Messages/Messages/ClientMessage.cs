using System;

namespace Crisis.Messages
{
    /// <summary>
    /// A message sent by the client to a server.
    /// </summary>
    [Serializable]
    public abstract class ClientMessage : Message
    {
    }
}
