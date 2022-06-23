using System;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Console;
namespace workingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            // string city = "London";

            // Write($"{city} is {city.Length} characters long");

            // WriteLine($"first char is {city[0]} and third is {city[2]}");


            string cities = "Paris,Berlin,Madrid,New York";

            string[] citiesArray = cities.Split(',');

            // for (int i = 0; i < citiesArray.Length; i++)
            // {
            //     WriteLine(citiesArray[i]);

            // }

            // string fullname = "Alan Jones";
            // int indexOfTheSpace = fullname.IndexOf(' ');

            // string firstname = fullname.Substring(startIndex: 0, length: indexOfTheSpace);

            // string lastname = fullname.Substring(startIndex: indexOfTheSpace + 1);

            // WriteLine($"{firstname} is the first name and {lastname} is the last name .");

            //example using indexof  and substrings

            // string fullname = "Jones, Alan";

            // int indexOfSpace = fullname.IndexOf(',');

            // string lastname = fullname.Substring(startIndex: 0, length: indexOfSpace);

            // string firstname = fullname.Substring(startIndex: indexOfSpace + 2);

            // WriteLine($"{firstname} {lastname}");


            // string company = "Microsoft";
            // bool startsWithM = company.StartsWith("M");
            // bool containsN = company.Contains("N");
            // WriteLine($"starts with M:{startsWithM}, contains n: {containsN}");

            // string word = "hello";
            // string word2 = "world";

            // string fullword = string.Join('*', word, word2);
            // WriteLine(fullword);

            // string recombined = string.Join("==>", citiesArray);
            // WriteLine(recombined);

            // string fruit = "apples";
            // decimal price = 0.39M;
            // DateTime when = DateTime.Today;

            // WriteLine($"{fruit} cost {price:C} on {when:dddd}.");
            // WriteLine(string.Format("{0} cost {1:C} on {2:dddd}.", fruit, price, when));


            // Write("Enter your email");
            // string input = ReadLine();

            // var ageChecker = new Regex(@"^[A-Za-z]{4,}[@][A-Za-z]+\.com$");

            // if (ageChecker.IsMatch(input))
            // {
            //     WriteLine("thank you");
            // }
            // else
            // {
            //     WriteLine($"this is not a valid email: {input}");
            // }
            // Write("Enter your password");
            // input = ReadLine();

            // var passChecker = new Regex(@"[A-Za-z]{8,}[@!$%&*]{1,}/d{1,}");

            // if (passChecker.IsMatch(input))
            // {
            //     WriteLine("Thanks that is  a good password");
            // }
            // else
            // {
            //     Write("that password does not follow the regulations 8 chars at least 1 special character, and at least 1 number ");
            // }


            string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
            // string[] filmsDumb = films.Split(',');


            // WriteLine("dumb attempt at splitting");
            // foreach (string film in filmsDumb)
            // {
            //     WriteLine(film);
            // }
            // splits monsters and inc because of the comma


            var csv = new Regex("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");

            MatchCollection filmSmart = csv.Matches(films);
            WriteLine("Smart attempt at splitting");


            foreach (Match film in filmSmart)
            {
                WriteLine(film.Groups[2].Value);
            }


        }
    }
}
