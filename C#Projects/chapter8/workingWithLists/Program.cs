using System;
using static System.Console;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Threading;

namespace workingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {


            var cities = new List<string>();

            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Milan");

            // WriteLine("initial list");
            // foreach (string city in cities)
            // {
            //     WriteLine($"{city}");
            // }

            // Console.WriteLine($"The first city is {cities[0]}");
            // Console.WriteLine($"The last city is {cities[cities.Count - 1]}");

            // cities.Insert(0, "sydney");


            // Console.WriteLine("after inserting sytdeny at index 0 ");
            // foreach (string city in cities)
            // {
            //     Console.WriteLine(city);
            // }

            // cities.RemoveAt(1);
            // cities.Remove("Milan");
            // Console.WriteLine("after removing 2 cities");

            // foreach (string city in cities)
            // {
            //     Console.WriteLine(city);
            // }

            var immutableCities = cities.ToImmutableList();
            var newList = immutableCities.Add("Rio");
            WriteLine("Immutable list of cities: ");
            foreach (string city in immutableCities)
            {
                WriteLine($"{city}");
            }

            WriteLine();
            WriteLine("New list of cities:");

            foreach (string city in newList)
            {
                WriteLine($"{city}");
            }
            WriteLine();

            int[] myarr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var i1 = new Index(value: 3, fromEnd: true);

            WriteLine(myarr[i1]);



        }
    }
}
