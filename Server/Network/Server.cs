using System.Collections.Generic;
using System.Threading.Tasks;
using Crisis.Messages;
using Crisis.Messages.Client;
using Hyalus;

namespace Crisis.Network
{
    static class Server
    {
        private static readonly Server<Message> server = new Server<Message>(new MessageCommunicator());
        private static readonly Dictionary<Connection<Message>, Client> clients = new Dictionary<Connection<Message>, Client>();

        public static void Start()
        {
            server.Start(Configuration.Port);
        }

        public static void Stop() => server.Stop();

        public static void AcceptMessages()
        {
            while (server.MessageAvailable)
            {
                var msg = server.NextMessage();
                clients[msg.Source].Receive((ClientMessage)msg.Message);
            }
        }

        public static void AcceptConnections()
        {
            while (server.ConnectionAvailable)
            {
                var conn = server.NextConnection();
                var client = new Client(conn, Disconnect);
                clients.Add(conn, client);
            }
        }

        private static void Disconnect(Connection<Message> conn)
        {
            clients.Remove(conn);
        }
    }
}
