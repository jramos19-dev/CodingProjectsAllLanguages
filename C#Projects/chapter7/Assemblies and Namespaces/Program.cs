using System;
using Packt.Shared;
using static System.Console;
using System.Xml.Linq;
using System.Threading.Tasks.Dataflow;
using DialectSoftware;
using DialectSoftware.Collections;
using Microsoft.VisualBasic;
using DialectSoftware.Collections.Generics;

namespace Assemblies_and_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XDocument();

            // example of string vs String
            // keywords do not need the namespace imported 

            // string s1 = "Hello";
            // String s2 = "World";

            Write("enTer a color value in hex: ");
            string hex = ReadLine();

            WriteLine("Is {0} a valid color value? {1}",
            arg0: hex, arg1: hex.isValidHex());

            Write("enter a xml tag: ");
            string xmlTag = ReadLine();

            WriteLine("is {0} a valid xml tag? {1}",
            arg0: xmlTag, arg1: xmlTag.IsValidXmlTag());

            WriteLine("enter a password");
            string password = ReadLine();

            WriteLine("Is {0} a valid password? {1}",
            arg0: password, arg1: password.IsValidPassword());

            var x = new Axis("X", 0, 10, 1);
            var y = new Axis("y", 0, 4, 1);

            var matrix = new Matrix<long>(new[] { x, y });
            for (int i = 0; i < matrix.Axes[0].Points.Length; i++)
            {
                matrix.Axes[0].Points[i].Label = "x" + i.ToString();
            }
            for (int i = 0; i < matrix.Axes[1].Points.Length; i++)
            {
                matrix.Axes[1].Points[i].Label = "y" + i.ToString();
            }
            foreach (long[] c in matrix)
            {
                WriteLine("{0},{1} ({2},{3}) = {4}",
                matrix.Axes[0].Points[c[0]].Label,
                matrix.Axes[1].Points[c[1]].Label,
                c[0], c[1], matrix[c]);
            }

        }
    }
}
