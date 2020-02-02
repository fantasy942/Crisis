using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crisis.Messages
{
    [Serializable]
    public class HearMessage : ServerMessage
    {
        public DateTime Time;
        public string Rank;
        public string Name;
        public string Text;
    }
}
