using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class ReadyMessage : ClientMessage
    {
        public bool Ready { get; }

        public ReadyMessage(bool ready)
        {
            Ready = ready;
        }

        public override void Visit(IClientHandler visitor)
        {
            visitor.HandleReady(this);
        }
    }
}
