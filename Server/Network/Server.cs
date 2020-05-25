using System.Collections.Generic;
using System.Threading.Tasks;
using Crisis.Messages;
using Crisis.Messages.Client;
using Hyalus;

namespace Crisis.Network
{
    /// <summary>
    /// Most interaction should happen through Clients. Use this class sparingly.
    /// </summary>
    static class Server
    {
        private static readonly Server<Message> server = new Server<Message>(new MessageCommunicator());
        private static readonly Dictionary<Connection<Message>, Client> clients = new Dictionary<Connection<Message>, Client>();

        public static void Start()
        {
            server.Start(Configuration.Port);
            _ = MessageLoop();
            _ = ConnectionLoop();
        }

        public static void Stop() => server.Stop();

        private static async Task MessageLoop()
        {
            while (server.Connected)
            {
                var msg = await server.NextMessageAsync();
                clients[msg.Source].Receive((ClientMessage)msg.Message);
            }
        }

        private static async Task ConnectionLoop()
        {
            while (server.Connected)
            {
                var conn = await server.NextConnectionAsync();
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
