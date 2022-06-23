using System;
using System.Reflection;
using static System.Console;
using System.Linq;
using System.Runtime.CompilerServices;

namespace workingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("assembly meta data: ");
            Assembly assembly = Assembly.GetEntryAssembly();
            WriteLine($"fullname: {assembly.FullName}");
            WriteLine($"Location: {assembly.Location}");

            var attributes = assembly.GetCustomAttributes();
            WriteLine($"attributes:");
            foreach (Attribute a in attributes)
            {
                WriteLine($"{a.GetType()}");
            }


            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();

            WriteLine($"version: {version.InformationalVersion}");
            WriteLine($" Company: {company.Company}");


            WriteLine();
            WriteLine($"* Types:");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                var compilerGenerated = type.GetCustomAttribute<CompilerGeneratedAttribute>();
                if (compilerGenerated != null) break;

                WriteLine();
                WriteLine($"Type: {type.FullName}");
                MemberInfo[] members = type.GetMembers();
                foreach (MemberInfo member in members)
                {
                    WriteLine("{0}: {1} ({2})",
                      arg0: member.MemberType,
                      arg1: member.Name,
                      arg2: member.DeclaringType.Name);

                    var coders = member.GetCustomAttributes<CoderAttribute>()
                      .OrderByDescending(c => c.LastModified);

                    foreach (CoderAttribute coder in coders)
                    {
                        WriteLine("-> Modified by {0} on {1}",
                          coder.Coder, coder.LastModified.ToShortDateString());
                    }

                }






            }
        }

        [Coder("Mark Price", "22 August 2019")]
        [Coder("Johnni Rasmussen", "13 September 2019")]
        public static void DoStuff()
        {
        }


    }

}