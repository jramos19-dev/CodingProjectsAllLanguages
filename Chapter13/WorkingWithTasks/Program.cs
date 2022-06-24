using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;


namespace WorkingWithTasks
{
    class Program
    {
        static decimal CallWebService()
        {
            WriteLine("Starting call to web service...");
            Thread.Sleep((new Random()).Next(2000, 4000));
            WriteLine("Finished call to web service");
            return 89.99M;
        }

        static string CallStoredProcedure(decimal amount)
        {
            WriteLine("Starting call to stored procedure...");
            Thread.Sleep();
        }

        static void MethodA()
        {
            WriteLine("starting method A");
            Thread.Sleep(3000); //simulate three seconds of work
            WriteLine("Finished method A");
        }
        static void MethodB()
        {
            WriteLine("starting method B");
            Thread.Sleep(2000);
            WriteLine("finished method b");

        }

        static void MethodC()
        {
            WriteLine("starting method c");
            Thread.Sleep(1000); //simulate one second of work
            WriteLine("finished method c");
        }

        static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            // WriteLine("Running methods synchronously on one thread.");
            // // this was calling all 3 methods synchronously 
            // MethodA();
            // MethodB();
            // MethodC();

            //now we will call the methods using different tasks and wrapping a thread in a new task so that it is easier to implement.
            //3 different ways to get the task running and created.
            WriteLine("running methods assynchronously on multiple threads.");
            Task taskA = new Task(MethodA);
            taskA.Start();
            Task taskB = Task.Factory.StartNew(MethodB);
            // // because the methods dont return a value then we can use the variable type Action.
            // // if we needed to return a value then we could use the Function type. Func
            Task taskC = Task.Run(new Action(MethodC));

            //created an array of type task and put our 3 tasks in ther eand then waited on all of them to finish. 
            Task[] tasks = { taskA, taskB, taskC };
            Task.WaitAll(tasks);


            // it is the cpu that allocates time slices to each process to allow them to execute their therads , you have no control over when the methods run. 


            WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms Elapsed");


        }
    }
}
