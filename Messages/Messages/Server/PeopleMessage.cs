using System;

namespace Crisis.Messages.Server
{
    public enum PeopleMessageType
    {
        Override,
        Arrived,
        Left
    }

    [Serializable]
    public class PeopleMessage : ServerMessage
    {
        public PeopleMessageType Type { get; }
        public string[] People { get; }

        public PeopleMessage(PeopleMessageType type, string[] people)
        {
            Type = type;
            People = people;
        }

        public override void Visit(IServerHandler visitor)
        {
            visitor.HandlePeople(this);
        }
    }
}
