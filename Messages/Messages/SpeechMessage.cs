using System;

namespace Crisis.Messages
{
    [Serializable]
    public class SpeechMessage : ClientMessage
    {
        public string Text;
    }
}
