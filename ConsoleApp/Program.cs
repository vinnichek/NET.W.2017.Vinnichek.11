using System;
using static Fibonacci.Logic.Fibonacci;
using ImitationWatches.Logic;

namespace ConsoleApp
{
    public static class MainClass
    {
        public static void Main(string[] args)
        {
            
            var iterator = GetFibonacciNumbers(50);
            foreach (var i in iterator)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            var watches = new ImitationWatches.Logic.ImitationWatches();

            var listener = new Listener(watches);

            var anotherListener = new AnotherListener();
            anotherListener.Register(watches);

            watches.SimulateImitationWatches("Hello!", 3000);

            listener.Unregister(watches);

            Console.WriteLine("\nUfter unregister...");
            watches.SimulateImitationWatches("Hello!", 3000);
        }
    }
}
