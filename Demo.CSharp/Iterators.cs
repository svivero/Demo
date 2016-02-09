using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Demo.CSharp
{
    class Iterators
    {
        public static IList<int> Fibonacci(int sequence)
        {
            IList<int> fibs = new List<int>();
            for (int i = 0, current = 1, previous = 0;  i < sequence; i++)
            {
                fibs.Add(current);
                int next = current + previous;
                previous = current;
                current = next;                
            }

            return fibs;
        }

        public static IEnumerable<int> FibonacciYielded(int sequence)
        {
            for (int i = 0, current = 1, previous = 0; i < sequence; i++)
            {
                yield return current;
                int next = current + previous;
                previous = current;
                current = next;               
            }
        }
    }

    [TestClass]
    public class IteratorTests
    {
        [TestMethod]
        public void Fibonacci_ReturnsSequence()
        {
            ICollection<int> fibs = Iterators.Fibonacci(10);
            int i = 0;

            foreach (int f in fibs)
            {
                Write(i++, f);
            }
        }

        void Write(int i, int fibVal)
        {
            Console.WriteLine(string.Format("Fib({0}) = {1}", i, fibVal));
        }

        [TestMethod]
        public void FibonacciYielded_ReturnsSequence()
        {
            IEnumerable<int> fibs = Iterators.FibonacciYielded(10);
            int i = 0;

            foreach(int f in fibs)
            {
                Write(i++, f);
            }
        }
    }
}
