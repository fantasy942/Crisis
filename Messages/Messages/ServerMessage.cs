using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
