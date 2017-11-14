using System;
using System.Collections.Generic;

namespace Fibonacci.Logic
{
    public class Fibonacci
    {
        /// <summary>
        /// Generate Fibonacci sequence.
        /// </summary>
        /// <param name="count">Count of numbers for generation.</param>
        /// <returns>Fibonacci sequence.</returns>
        public static IEnumerable<long> GetFibonacciNumbers(int count)
        {
            if (count <= 0)
                throw new ArgumentException($"{nameof(count)} not valid.");
            
            return Enumerate();

            IEnumerable<long> Enumerate()
            {
                long prevNumber = -1;
                long nextNumber = 1;
                long temp;

                for (int i = 0; i < count; i++)
                {
                    temp = nextNumber;
                    yield return nextNumber += prevNumber;
                    prevNumber = temp;
                }
            }
        }
    }
}
