using System;
using System.Collections.Generic;

namespace EventsAndDelegates
{

    public class PassengerDetails : EventArgs
    {
        public Passenger Passenger
        {
            get; set;
        }
    }
    public class Airline
    {
        private static readonly object obj = new object();


        public event EventHandler<PassengerDetails> Informed;
       

        public string Name { set; get; }
        public List<string> destination = new List<string>();




        public Airline(List<string> dest, string name)
        {
            this.destination = dest;
            this.Name = name;

        }

        public void CreateTicket(string a , int b, string c)
        {
            lock (obj)
            {
                var passenger = Passenger.GetInstance;
                passenger.SetValues(a, b, c);
                SendToECL(passenger);
            }
        }

        protected virtual void SendToECL(Passenger passenger)
        {
            Informed(this, new PassengerDetails() { Passenger = passenger });
        }
    }
}
