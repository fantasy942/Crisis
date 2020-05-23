using Crisis.Messages;
using Hyalus;
using System;
using System.IO;
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
            var mem = new MemoryStream();
            formatter.Serialize(mem, message);
            mem.WriteTo(destination);
        }
    }
}
