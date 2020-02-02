using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Crisis.Network;
using Crisis.Messages;

namespace Crisis.Network
{
    /// <summary>
    /// Most interaction should happen through Clients. Use this class sparingly.
    /// </summary>
    static class Server
    {
        private static readonly Telepathy.Server server = new Telepathy.Server();

        private static readonly ConcurrentDictionary<int, Client> clients = new ConcurrentDictionary<int, Client>();
        public static IReadOnlyDictionary<int, Client> Clients => clients;

        public static void Start()
        {
            server.Start(Configuration.Port);
            Task.Run(DequeueLoop);
        }

        public static void Send(Client destination, Message msg)
        {
            server.Send(destination.ID, msg.Serialize());
        }

        public static void Disconnect(Client client)
        {
            server.Disconnect(client.ID);
            clients.TryRemove(client.ID, out Client _);
        }

        public static void Stop() => server.Stop();

        private static void DequeueLoop()
        {
            while (server.Active)
            {
                try
                {
                    while (server.GetNextMessage(out Telepathy.Message msg))
                    {
                        switch (msg.eventType)
                        {
                            case Telepathy.EventType.Connected:
                                clients.TryAdd(msg.connectionId, new Client(msg.connectionId));
                                break;
                            case Telepathy.EventType.Data:
                                if (Message.TryInfer(msg.data, out Message inferred))
                                {
                                    clients[msg.connectionId].Receive(inferred);
                                }
                                break;
                            case Telepathy.EventType.Disconnected:
                                clients[msg.connectionId].Disconnect();
                                break;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

    }
}
