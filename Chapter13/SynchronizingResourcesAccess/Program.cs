using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;
using System.Net.Http;

namespace SynchronizingResourcesAccess
{
    class Program
    {
        static Random r = new Random();
        static string message;

        // adding a conch . like in spongebob so that they can take turns performing their task while sharing resources.
        // the conch also protects everything that is a shared resource and is placed in the program class. 
        static object conch = new object();

        //countrs how many operations have occured
        static int counter; // another shared resource
        static void MethodA()
        {
            try
            {
                Monitor.TryEnter(conch, TimeSpan.FromSeconds(15));
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(r.Next(2000));
                    message += "A";
                    Interlocked.Increment(ref counter);
                    Write(".");
                }
            }
            finally
            {
                Monitor.Exit(conch);
            }
        }
        static void MethodB()
        {
            try
            {
                Monitor.TryEnter(conch, TimeSpan.FromSeconds(15));

                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(r.Next(2000));
                    message += "B";
                    Interlocked.Increment(ref counter);
                    Write(".");
                }
            }
            finally
            {
                Monitor.Exit(conch);
            }
        }
        static void Main(string[] args)
        {
            WriteLine("Please wait for the tasks to complete.");
            Stopwatch watch = Stopwatch.StartNew();

            Task a = Task.Factory.StartNew(MethodA);
            Task b = Task.Factory.StartNew(MethodB);

            Task.WaitAll(new Task[] { a, b });

            WriteLine();
            WriteLine($"Results: {message}");
            WriteLine($"{watch.ElapsedMilliseconds:#,##0} elapsed ElapsedMilliseconds");

            WriteLine($"string modifications: {counter}");



        }
    }
}
