using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace linqInParallel
{
    class Program
    {
        static void Main(string[] args)
        {
           
           var watch = Stopwatch.StartNew();
           Write("Press enter to start:");
           ReadLine();
           watch.Start();

           IEnumerable<int> numbers =  Enumerable.Range(1, 200_000_000);
        //    var squares = numbers.Select(number=> number * number).ToArray();
        
        //making a call to asparrallel extension to do more than one cpu
        var squares = numbers.AsParallel()
        .Select(n => n * n).ToArray();


           watch.Stop();
           WriteLine("{0:#,##0} elapsed milliseconds. ", watch.ElapsedMilliseconds);

        }
    }
}
