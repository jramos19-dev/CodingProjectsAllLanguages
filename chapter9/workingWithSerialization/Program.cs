using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using static System.Console;
using static System.Environment;
using static System.IO.Path;
using static workingWithSerialization.Person;
using System.Threading.Tasks;
 using NuJson = System.Text.Json.JsonSerializer;

namespace workingWithSerialization

{
    class Program
    {
        static async Task Main(string[] args)
        {
            //create an object graph
            var people = new List<Person>{
                new Person(3000M){FirstName ="Alice", 
                LastName= "Smith", 
                DateofBirth= new DateTime(1974, 3, 14)}, 

                new Person (4000M){FirstName="BOB", 
                LastName ="Jones", 
                DateofBirth= new DateTime(1990,4,5)},

                new Person(5000M){FirstName = "Charlie",
                LastName="Cox", 
                DateofBirth= new DateTime(2006,3,5),
                Children= new HashSet<Person>{
                    new Person(0M) { FirstName="sally", 
                    LastName="Cox",
                    DateofBirth = new DateTime(2015,5,1)}
                }
                }
            };

            //creating an object that will format the list of Persons as xml 
            var xs = new XmlSerializer(typeof(List<Person>));

            //creating a string file to write to
            string path = Combine(CurrentDirectory, "People.xml");

            // the using statement is so that you can use the filestream feature that automatically disposes of resources
            using (FileStream stream = File.Create(path)){
                xs.Serialize(stream, people);
            }

            WriteLine("Written {0:N0} bytes of XML  to {1}", 
            arg0: new FileInfo(path).Length, 
            arg1: path);

            WriteLine();

            //display the serialized object graph
            WriteLine(File.ReadAllText(path));
        
            
            using(FileStream xmlLoad = File.Open(path,FileMode.Open)){
                //deserialize and cast the object graph into a list of Person
                var loadedPeople = (List<Person>)xs.Deserialize(xmlLoad);

                foreach(var item in loadedPeople){
                    WriteLine("{0} has {1} children.", 
                    item.LastName, item.Children.Count);
                }
            }

            //create a file to go to 
            string jsonPath = Combine(CurrentDirectory,"people.json");

            using(StreamWriter jsonStream = File.CreateText(jsonPath)){
                //create an object  that will format as json
                 var jss = new Newtonsoft.Json.JsonSerializer();
                 //serialize the ojbect graph into a string 
                 jss.Serialize(jsonStream,people);
            }
            WriteLine();
            WriteLine("Written {0:N0} bytes of Json to: {1}", 
            arg0: new FileInfo (jsonPath).Length, arg1: jsonPath);

            //display the serialized object graph
            WriteLine(File.ReadAllText(jsonPath));
            
            using (FileStream jsonLoad = File.Open(jsonPath,FileMode.Open)){
                //desearlize object graph into a list of person 
                var loadedPeople = (List<Person>)
                await NuJson.DeserializeAsync(
                    utf8Json: jsonLoad,
                    returnType: typeof(List<Person>));

                    foreach(var item in loadedPeople){
                        WriteLine("{0} has {1} children.", 
                        item.LastName, item.Children?.Count);
                    }
                
            }

           
        }
    }
}
