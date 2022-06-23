
using System;
using System.Reflection;
using static System.Console;
namespace workingWithReflection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class CoderAttribute : Attribute
    {

        public string Coder { get; set; }
        public DateTime LastModified { get; set; }

        public CoderAttribute(string coder, string lastmodified)
        {

            Coder = coder;
            LastModified = DateTime.Parse(lastmodified);
        }
    }


}
