using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Crisis.Messages;
using System.Threading;
using Crisis.Messages.Client;
using System.Configuration;
using System.Runtime.Remoting.Channels;

namespace Crisis.Network
{
    /// <summary>
    /// Most interaction should happen through Clients. Use this class sparingly.
    /// </summary>
    static class Server
    {
        private static readonly Hyalus.Server<Message> server = new Hyalus.Server<Message>(new MessageCommunicator());
        private static readonly Dictionary<Hyalus.Connection<Message>, Client> clients = new Dictionary<Hyalus.Connection<Message>, Client>();

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
                clients.Add(conn, new Client(conn));
            }
        }

    }
}
