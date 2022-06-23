
using static System.Console;


namespace Packt.Shared


{
    public interface Iplayable
    {

        void Play();
        void Pause();

        void Stop(){
            WriteLine("Default implementation of stop");
        }

    }
}