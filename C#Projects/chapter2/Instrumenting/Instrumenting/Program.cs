using static System.Console;
using System.Diagnostics;


Trace.Listeners.Add(new TextWriterTraceListener(
    File.CreateText("log.txt")
));
Trace.AutoFlush = true;

Debug.WriteLine("Debug says, Iam watching!");
Trace.WriteLine("Trace says, I am watching");