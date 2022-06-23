using System;
using  System.Collections.Generic;
using System.Xml.Serialization;


namespace workingWithSerialization
{
    public class Person
    {
        
        public Person(){

        }
        public Person(decimal initialSalary){
            }
            [XmlAttribute("fname")]
            public string FirstName{get;set;}
            [XmlAttribute("lname")]
            public string LastName{get;set;}
            [XmlAttribute("DOB")]
            public DateTime DateofBirth{get;set;}
            public HashSet<Person> Children{get;set;}

            //setting it protected restrains the property to be shown in the xml that is serialized;
            protected decimal Salary{get;set;}
        


    }
}