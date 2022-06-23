using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : IComparable<Person>
    {
            //fields
            public string Name;
            public DateTime DateOfBirth;
            public List<Person>Children = new List<Person>();
            
            //methods
            // THe compare to method. is how we are implementing the Icomparable interface
            public int CompareTo(Person other){
                return Name.CompareTo(other.Name);
            }




            public void writeToConsole(){
                WriteLine($"{Name} was born on {DateOfBirth}");
                
            }
            // static method to procreate
            public static Person Procreate(Person p1, Person p2){

                    var baby = new Person {
                        Name= $"Baby of {p1.Name} and {p2.Name}"
                    };
                    p1.Children.Add(baby);
                    p2.Children.Add(baby);

                    return baby;
            }
            // instance method to procreate
            public Person Procreatewith(Person partner){
                return Procreate(this,partner);
            }

            // making method with operator functionality
            public static Person operator *(Person p1, Person p2){
                return Person.Procreate(p1,p2);
            }

            // method with a local function 
            public static int factorial(int number){

                if (number < 0){
                    throw new ArgumentException(
                        $"{nameof(number)} cannot be less than zero"
                    );

                }
                return localfactorial(number);
                
                //local function inside a method
                int localfactorial(int localnumber){
                    if (localnumber< 1)return 1;
                    return localnumber * localfactorial(localnumber -1 );
                    
                }
            }
                // adding new  delegate field
                public event EventHandler shout ;
                //data field
                public int Angerlevel;
                
                //method
                public void Poke(){
                    Angerlevel++;
                    if(Angerlevel >= 3){
                        //if something is listening 
                        if (shout != null){
                            // then call the delegate
                            shout(this, EventArgs.Empty);
                        }
                        
                    }
                }



    }
}   
            




