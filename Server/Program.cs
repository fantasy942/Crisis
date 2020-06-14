using Crisis.Network;
using Crisis.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Crisis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Migrating database...");
            Database.Game.Database.Migrate();
            Console.WriteLine("Starting server...");
            Server.Start();
             _ = Loop();
            Console.WriteLine("Running.");
            Console.WriteLine("Press ESC to stop.");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape) { }
            stop = true;
            Console.WriteLine("ESC received.");
            Console.WriteLine("Saving database...");
            Database.Game.SaveChanges();
            Console.WriteLine("Done.");
            Console.WriteLine("Halting.");
        }

        private static bool stop = false;

        private static async Task Loop()
        {
            DateTime nextSave = DateTime.UtcNow + Configuration.SaveInterval;
            while (!stop)
            {
                Server.AcceptConnections();
                Server.AcceptMessages();

                foreach (var item in Client.Clients)
                {
                    item.Send();
                }

                if (DateTime.UtcNow >= nextSave)
                {
                    nextSave = DateTime.UtcNow + Configuration.SaveInterval;
                    Console.WriteLine("Saving database...");
                    Database.Game.SaveChanges();
                    Console.WriteLine("Saved successfully.");
                }

                await Task.Delay(1);
            }
        }
    }
}
