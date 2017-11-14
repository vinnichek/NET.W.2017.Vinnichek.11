using System;
using static Fibonacci.Logic.Fibonacci;

namespace ConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            var iterator = GetFibonacciNumbers(50);
            foreach (var i in iterator)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
