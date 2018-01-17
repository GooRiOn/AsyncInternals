using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CustomAwaitable
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Do you want to run this method synchronously? Y/N");

            var answer = Console.ReadKey();
            var isCompleted = answer.Key == ConsoleKey.Y;

            Console.Clear();
            Console.WriteLine($"Running...");

            var result = await new CustomAwaitable(isCompleted);

            Console.Write(result);
            Console.ReadKey();
        }
    }
}
