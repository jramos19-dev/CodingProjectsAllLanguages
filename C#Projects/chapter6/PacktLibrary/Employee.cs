using System;
using System.Net.Mail;
using System.Threading;
using static System.Console;
namespace Packt.Shared
{
    public class Employee : Person
    {
        public string emplyeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public new void WriteToConsole()
        {
            WriteLine(format:
            "{0} and was born on {1:dd/mm/yy} and hired on {2:dd/mm/yy}",
            arg0: Name,
            arg1: DateOfBirth,
            arg2: HireDate
            );

        }
        public override string ToString()
        {
            return $"{Name}'s cod is {emplyeeCode}}";
        }
    }
}