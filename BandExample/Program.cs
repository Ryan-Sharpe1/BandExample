using System;

namespace BandExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Venue venue = new Venue();
            venue.VenueCheck();
            Band band = new Band();
            band.AddBand();

            var repeat = true;
            while (repeat)
            {
                Console.WriteLine("Add Musician, Announce, Next Band or Quit?");
                Console.WriteLine("");
                var action = Console.ReadLine();
                if (action == "Add Musician" | action == "Add")
                {
                    Console.WriteLine("");
                    band.AddMusician();
                }
                else if (action == "Announce" | action == "announce")
                {
                    Console.WriteLine("");
                    band.Announce();
                }
                else if (action == "Quit" | action == "Bye" | action == "quit")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                }
                else if (action == "Next Band" | action == "Next")
                {
                    Console.WriteLine("");
                    band.Musicians.Clear();
                    band.AddBand();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine(action + " is not a valid action");
                }
            }
        }
    }
}
