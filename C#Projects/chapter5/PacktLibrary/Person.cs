using System;
using System.Collections.Generic;
namespace Packt.Shared
{
    public class Person : Object

    {
        public readonly string Homeplanet = "Earth";
        public readonly DateTime Instantiated;

        //constructors
        public Person()
        {
            //default value for fields
            // incluidng read-only fields
            Name = "unknown";
            Instantiated = DateTime.Now;
        }
        public Person(string name, string homeplanet)
        {
            Name = name;
            Homeplanet = homeplanet;
            Instantiated = DateTime.Now;

        }

        public const string Species = "Homo Sapien";
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld BucketList;
        public WondersOfTheAncientWorld FavoriteAncientWonder;

        public List<Person> Children = new List<Person>();
    }
}
