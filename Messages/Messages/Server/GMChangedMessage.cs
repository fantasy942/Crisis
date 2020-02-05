using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class GMChangedMessage : Message
    {
        public bool IsGM;
    }
}
