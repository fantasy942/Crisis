using System;

namespace Crisis.Messages
{
    /// <summary>
    /// A message sent by the server to a client.
    /// </summary>
    [Serializable]
    public abstract class ServerMessage : Message
    {
    }
}
