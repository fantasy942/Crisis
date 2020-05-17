using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class SpeechMessage : ClientMessage
    {
        public string Text;

        public override void Visit(IClientVisitor visitor)
        {
            visitor.VisitSpeech(this);
        }
    }
}
