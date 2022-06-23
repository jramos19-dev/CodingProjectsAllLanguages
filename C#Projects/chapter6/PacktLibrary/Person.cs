using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace Packt.Shared
{
    public class Person
    {
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        //methods
        /// <summary>
        /// This method prints out name and dateofBirth, doesnt take any parameters.
        /// </summary>
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd}.");
        }

    }
}
