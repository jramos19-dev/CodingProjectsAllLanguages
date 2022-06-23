using System;

namespace Packt.Shared
{
    public class GenericThing<T> where T: IComparable
    {
        public T Data = default(T);
        
        public string Process(T input){

            if (Data.CompareTo(input) ==0){

                return "Data is the same as input";
            }
            else{
                return "Data and input are Not the same";
            }

        }


    }
}