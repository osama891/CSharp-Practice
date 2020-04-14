using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "Faraz", "Osama", "Ali" };
            var fia = new ECL(list);
            var dest = new List<string> { "KHI", "LHR", "UAE" };
            var airline1 = new Airline(dest, "PIA");
            var airline2 = new Airline(dest, "PIA");

            airline1.Informed += fia.Check;
            airline2.Informed += fia.Check;

            Parallel.Invoke(() => airline1.CreateTicket("osama", 47, "LHR"),
                 ()=> airline2.CreateTicket("Osama", 48, "KHI"));




        }
    }
}
