using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class SpeechMessage : Message
    {
        public string Text;
    }
}
