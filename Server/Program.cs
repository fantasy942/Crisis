using Crisis.Network;
using Crisis.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;

namespace Crisis
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Migrating database...");
            Database.Context.Database.Migrate();
            System.Console.WriteLine("Starting server...");
            Server.Start();
            System.Console.WriteLine("Running.");
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
