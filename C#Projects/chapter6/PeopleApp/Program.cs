using System;
using Packt.Shared;
using static System.Console;
namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 8);
            var dv3 = dv1 + dv2;

            WriteLine($"({dv1.x} , {dv1.y})+ ({dv2.x},{dv2.y}) = ({dv3.x}, {dv3.y}) ");

            Employee john = new Employee
            {
                Name = "john Jones",
                DateOfBirth = new DateTime(1990, 8, 28)
            };
            john.WriteToConsole();

            john.emplyeeCode = "JJ001";
            john.HireDate = new DateTime(2014, 11, 23);
            WriteLine($"{john.Name} was hired on {john.HireDate:dd/mm/yyyy}");

            john.WriteToConsole();
            WriteLine(john.ToString());
        }
    }
}
