using System;
using System.Numerics;
using static System.Console;


namespace workingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var largest = ulong.MaxValue;

            Console.WriteLine($"{largest,40:N0}");

            var atomsInTheUniverse = BigInteger.Parse("1234556780123323434534545645690");
            Console.WriteLine($"{atomsInTheUniverse,40:N0}");


            var c1 = new Complex(4, 2);
            var c2 = new Complex(3, 7);

            var c3 = c1 + c2;

            WriteLine($"{c1} added to {c2} is {c3}");


        }
    }
}
