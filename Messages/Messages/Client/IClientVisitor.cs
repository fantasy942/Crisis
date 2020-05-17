using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crisis.Messages.Client
{
    public interface IClientVisitor
    {
        void VisitAuth(AuthMessage msg);
        void VisitRegister(RegisterMessage msg);
        void VisitSpeech(SpeechMessage msg);
    }
}
