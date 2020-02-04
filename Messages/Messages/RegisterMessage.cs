using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crisis.Messages
{
    [Serializable]
    public class RegisterMessage : ClientMessage
    {
        public string Username;
        public string Password;
    }
}
