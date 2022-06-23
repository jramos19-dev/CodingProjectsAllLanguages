using System;
using System.Diagnostics;
using static System.Console;
using static System.Diagnostics.Process;

namespace Packt.Shared{
    public static class Recorder{
        static Stopwatch timer = new Stopwatch();
        static long bytesPhysicalBefore=0;
        static long bytesVirtualBefore=0;

        public static void Start(){
            //force two garabage collections to release memory thatis 
            //no longer referenced but has not been released
            gc
        }

    }
}