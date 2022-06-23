using System;
using static System.Console;

namespace workingWithRanges
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Samantha Jones";
            int indexOfSpace = name.IndexOf(' ');

            int lengthOfFirst = name.IndexOf(' ');
            int lengthOfLast = name.Length - name.IndexOf(' ') - 1;

            string firstName = name.Substring(startIndex: 0,
            length: indexOfSpace);

            string LastName = name.Substring(startIndex: name.Length - (name.Length - indexOfSpace - 1),
            length: name.Length - indexOfSpace - 1);

            WriteLine($"first aname {firstName} , LastName : {LastName}");

            ReadOnlySpan<char> nameasSpan = name.AsSpan();

            var firstNameSpan = nameasSpan[0..lengthOfFirst];
            var lastNameSpan = nameasSpan[^lengthOfLast..^0];

            WriteLine($"First name {firstNameSpan.ToString()} lastname : {lastNameSpan.ToString()}");

            
        }
    }
}
