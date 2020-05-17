using Crisis.Messages;
using Hyalus;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Crisis
{
    public class MessageCommunicator : Communicator<Message>
    {
        private readonly BinaryFormatter formatter = new BinaryFormatter();

        public override Message Receive(NetworkStream source)
        {
            return (Message)formatter.Deserialize(source);
        }

        public override void Send(NetworkStream destination, Message message)
        {
            formatter.Serialize(destination, message);
        }
    }
}
