using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class SpeechMessage : ClientMessage
    {
        public string Text { get; }

        public SpeechMessage(string text)
        {
            Text = text;
        }

        public override void Visit(IClientHandler visitor)
        {
            visitor.HandleSpeech(this);
        }
    }
}
