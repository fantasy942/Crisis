using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crisis.Messages.Server
{
    /// <summary>
    /// Represents a server to client message.
    /// </summary>
    [Serializable]
    public abstract class ServerMessage : Message
    {
        public abstract void Visit(IServerVisitor visitor);
    }
}
