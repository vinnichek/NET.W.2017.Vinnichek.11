using System;
using System.Collections.Generic;
using System.Numerics;

namespace Fibonacci.Logic
{
    public class Fibonacci
    {
        /// <summary>
        /// Generate Fibonacci sequence.
        /// </summary>
        /// <param name="count">Count of numbers for generation.</param>
        /// <returns>Fibonacci sequence.</returns>
        public static IEnumerable<BigInteger> GetFibonacciNumbers(int count)
        {
            if (count < 0)
                throw new ArgumentException($"{nameof(count)} not valid.");

            return FibonacciCore(count);

            IEnumerable<BigInteger> FibonacciCore(int length)
            {
                BigInteger previous = 1,
                next = 1;

                for (int i = 0; i < length; i++)
                {
                    yield return previous;

                    var temp = next;
                    next = previous + next;
                    previous = temp;
                }

            }
        }
    }
}
