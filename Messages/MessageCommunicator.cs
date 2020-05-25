using Crisis.Messages;
using Hyalus;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Crisis
{
    public class MessageCommunicator : Communicator<Message>
    {
        private readonly BinaryFormatter formatter = new BinaryFormatter();

        public override Message Deserialize(Stream source)
        {
            return (Message)formatter.Deserialize(source);
        }

        public override void Serialize(Stream destination, Message message)
        {
            formatter.Serialize(destination, message);
        }
    }
}
