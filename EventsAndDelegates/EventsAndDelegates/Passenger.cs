using System;
namespace EventsAndDelegates
{
    public sealed class Passenger
    {
        private static int counter = 0;
        readonly int initialId = 100;
        public int Id { get; }
        public string Name
        {
            get; set;
        }

        public int Seat
        {
            get; set;
        }

        public string Destination
        {
            get; set;
        }

        private static readonly Lazy<Passenger> instance = new Lazy<Passenger>(() => new Passenger());

        public static Passenger GetInstance
        {
            get
            {
                return instance.Value;
            }

   
        }

        private Passenger()
        {
            counter++;
            Console.WriteLine($"value of counter {counter}");
            this.Id = initialId;
            initialId++;
          

        }

        public void SetValues (string name, int seat, string dest)
        {
            this.Seat = seat;
            this.Destination = dest;
            this.Name = name;


        }

    }
}
