using System;
using System.Collections.Generic;

namespace EventsAndDelegates
{
   public delegate bool Function(string x);


    public class ECL
    {
        protected List<string> Names = new List<string>();
        public ECL(List<string> eclist)
        {
            this.Names = eclist;
        }

        public void Check(object source, PassengerDetails e)
        {
            this.CheckName(e.Passenger.Name.ToString(), ListTraversal);
        }

        private bool ListTraversal(string x)

        {
            bool y = false;

            foreach (string name in this.Names)
            {
                if (name == x)
                     y = true;
    
            }

            return y;
    

        }

        public void CheckName(string name, Function f)
        {
            var x = f(name);
            Console.WriteLine($"value in ecl is present: {x}");

        }


    }
}
