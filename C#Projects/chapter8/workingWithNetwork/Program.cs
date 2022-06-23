using System;
using System.IO;
using System.Net;
using System;
using System.Security;
using static System.Console;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Security.Authentication.ExtendedProtection;

namespace workingWithNetwork
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a valid web address:");
            string url = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(url))
            {
                url = "https://world.episerver.com/cms/?q=pagetype";
            }


            var uri = new Uri(url);
            WriteLine($"URL: {url}");
            WriteLine($"scheme: {uri.Scheme}");
            WriteLine($"Port: {uri.Port}");
            WriteLine($"uri.Host; {uri.Host}");
            WriteLine($"Patch: {uri.AbsolutePath}");
            WriteLine($"query: {uri.Query}");


            IPHostEntry entry = Dns.GetHostEntry(uri.Host);
            WriteLine($"{entry.HostName} has the following ip adddresses:");
            foreach (IPAddress adress in entry.AddressList)
            {
                WriteLine($"{adress}");
            }

            try
            {
                var ping = new Ping();
                WriteLine("pinging server. Please wait...");
                PingReply reply = ping.Send(uri.Host);
                WriteLine($"{uri.Host} was p;inged and replied {reply.Status}");

                if (reply.Status == IPStatus.Success)
                {
                    WriteLine("Reply from {0} took {1:N0}ms", reply.Address, reply.RoundtripTime);
                }

            }
            catch (Exception e)
            {
                WriteLine($"{e.GetType().ToString()} asys {e.Message}");
            }




        }
    }
}
