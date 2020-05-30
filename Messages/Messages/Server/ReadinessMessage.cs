using System;

namespace Crisis.Messages.Server
{
    [Serializable]
    public class ReadinessMessage : ServerMessage
    {
        public byte StaffReady { get; }
        public byte StaffNeeded { get; }
        public byte HeadsReady { get; }
        public byte HeadsNeeded { get; }

        public ReadinessMessage(byte staffready, byte staffneeded, byte headsready, byte headsneeded)
        {
            StaffReady = staffready;
            StaffNeeded = staffneeded;
            HeadsReady = headsready;
            HeadsNeeded = headsneeded;
        }

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandleReadiness(this);
        }
    }
}
