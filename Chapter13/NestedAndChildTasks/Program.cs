using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;
using System.IO;
using Microsoft.VisualBasic;

namespace NestedAndChildTasks
{
    class Program
    {

        static void OuterMethod()
        {
            WriteLine("Outer Method Starting...");
            //to change the default behavior of only waiting on the outer task and ignoring the completion of the inner task we use this line
            var inner = Task.Factory.StartNew(InnerMethod, TaskCreationOptions.AttachedToParent);
            WriteLine("OuterMethod finished");
        }
        static void InnerMethod()
        {
            WriteLine("Inner Method starting...");
            Thread.Sleep(2000);
            WriteLine("Inner method finished.");
        }

        static void Main(string[] args)
        {

            var outer = Task.Factory.StartNew(OuterMethod);


            outer.Wait();
            WriteLine("console app is stopping");




        }
    }
}
