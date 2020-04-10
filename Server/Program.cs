using Crisis.Network;
using System.Threading;

namespace Crisis
{
    class Program
    {
        static void Main(string[] args)
        {
            Server.Start();
            Thread.Sleep(Timeout.Infinite);
        }
    }
}
