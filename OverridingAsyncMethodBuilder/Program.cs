using System;
using System.Threading.Tasks;

namespace OverridingAsyncMethodBuilder
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(1000);
            Console.ReadLine();
        }
    }
}
