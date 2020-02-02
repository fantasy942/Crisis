using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crisis.Messages
{
    [Serializable]
    public class AuthMessage : ClientMessage
    {
        public string Username;
        public string Password;
    }
}
