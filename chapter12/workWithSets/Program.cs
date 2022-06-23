using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace workWithSets
{
    class Program
    {
        static void Output (IEnumerable<string> cohort, string description = ""){
            if(!string.IsNullOrEmpty(description)){
                WriteLine(description);
            }
            Write("  ");
            WriteLine(string.Join(", ", cohort.ToArray()));
        }
        static void Main(string[] args)
        {
            
            var cohort1 = new string []
            {"Rachel", "Gareth", "Jonathan", "George"};
            var cohort2 = new string []
            {"jack", "Stephen", "Daniel" ,"Jack", "Jared"};
            var cohort3 = new string[]
            {"Declan", "Jack", "Jack", "Jasmine", "Conor"};

            Output(cohort1,"Cohort1");
            Output(cohort2,"Cohort2");
            Output(cohort3,"Cohort3");
            WriteLine();
            Output(cohort2.Distinct(),"cohort2.distinct():");
            WriteLine();
            Output(cohort2.Union(cohort3), "cohort2 union cohort3:");
            WriteLine();
            Output(cohort2.Concat(cohort3), "cohort 2 concat cohort 3: ");
            WriteLine();
            Output(cohort2.Intersect(cohort2), "cohort 2 intersect cohort 3: ");
            WriteLine();
            Output(cohort1.Zip(cohort2,(c1,c2)=> $"{c1} matched with {c2}"), "cohort.zip(cohort2): ");


        }
    
    }
}
