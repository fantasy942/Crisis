using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
