using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class RegisterMessage : Message
    {
        public string Username;
        public string Password;
    }
}
