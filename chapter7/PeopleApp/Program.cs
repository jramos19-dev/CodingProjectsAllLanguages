using System;
using Packt.Shared;
using static System.Console;
namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var harry = new Person{Name = "Harry"};
            // var mary = new Person{Name = "Mary"};
            // var jill = new Person{Name = "JIll"};

            // //calling instance method
            // var baby1 = mary.Procreatewith(harry);

            // //calling the static method

            // var baby2 = Person.Procreate(harry,jill);

            // WriteLine($"{harry.Name } has {harry.Children.Count} children");
            // WriteLine($"{mary.Name} has {mary.Children.Count} children");
            // WriteLine($"{jill.Name} has {jill.Children.Count}");
            //   //call static method to multiply using the operator *
          
            //   var baby3 = harry * jill;

            // WriteLine( $"dang sucka this guy {harry.Name} got {harry.Children.Count} children");


            // WriteLine($" 5! is equal to {Person.factorial(5) }");

            // //delegate practice function
        
            // harry.shout += Harry_shout;
            // harry.Poke();
            // harry.Poke();
            // harry.Poke();
            // harry.Poke();


              Person[] people = {
            new Person {Name= "Simon"},
            new Person {Name= "Jenny"},
            new Person {Name= "Mihir"},
            new Person {Name= "Richard"}
        };
        // unsorted array of people
            WriteLine("Initial  list of peple:");
            foreach (var person in people){
                WriteLine($"{person.Name}");
            }
                WriteLine("\n\n");
        // to sort them we use the i comparable implementation present in the person class, it has to be in the person class declaration.
            Array.Sort(people);
            foreach (var person in people){
                WriteLine($"{person.Name} ");
            }
            
            WriteLine("\n\n");

            // this is using the IcOMParer implementation of the personComparer class
            Array.Sort(people, new PersonComparer());
            foreach(var person in people){
                WriteLine($"{person.Name}");
            }

            var t1 = new Thing();
            t1.Data = 42;
            WriteLine($"Thing with an Integer: {t1.Process(42)} ");


            var t2 = new Thing();
            t2.Data= "apple";
            WriteLine($"thing with a string : {t2.Process("apple") }");


            var gt1 = new GenericThing<int>();
            gt1.Data = 42;  
            WriteLine($"Generic thing with an integer {gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";
            WriteLine($"GenericThing with a string: {gt2.Process("apple")}");


            string number1 = "4";
            WriteLine("{0} squared is {1}",
            arg0: number1,
            arg1: Squarer.Square<string>(number1)
            );

            byte number2 = 3;
            WriteLine("{0} squared is {1}",
            arg0:number2,
            arg1:Squarer.Square(number2)
            );

            

        }
            // // this is a delegate and it is outside the main method.  
            // private static void Harry_shout(object sender, EventArgs e){
            //     Person p  = (Person)sender;
            //     WriteLine($"{p.Name} is this angry: {p.Angerlevel}");
            // }

        
      

    




    }
}
