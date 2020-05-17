using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crisis.Messages.Client
{
    /// <summary>
    /// Represents a client to server message.
    /// </summary>
    [Serializable]
    public abstract class ClientMessage : Message
    {
        public abstract void Visit(IClientVisitor visitor);
    }
}
