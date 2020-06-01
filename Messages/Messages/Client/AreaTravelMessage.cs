using System;

namespace Crisis.Messages.Client
{
    [Serializable]
    public class AreaTravelMessage : ClientMessage
    {
        /// <summary>
        /// Null signifies an abort.
        /// </summary>
        public string Area { get; }

        public AreaTravelMessage(string area)
        {
            Area = area;
        }

        public override void Visit(IClientHandler visitor)
        {
            visitor.HandleArea(this);
        }
    }
}
