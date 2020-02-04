using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crisis.Messages.Server
{
    public enum RegisterResponse
    {
        Ok,
        NameTaken
    }

    [Serializable]
    public class RegisterResponeMessage : Message
    {
        public RegisterResponse Response;
    }
}
