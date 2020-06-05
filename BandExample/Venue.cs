using System;
namespace BandExample
{
    public class Venue
    {
        public string VenueName;
        public int crowdSize = 0;


        public void VenueCheck()
        {
            Console.WriteLine("What is the name of the Venue?");
            Console.WriteLine("");
            VenueName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("What is the crowd size tonight?");
            Console.WriteLine("");

            if (!int.TryParse(Console.ReadLine(), out crowdSize))
            {
                Console.WriteLine("Invalid Input for Crowd Size");
                Environment.Exit(0);
            }
            if (crowdSize==1)
            {
                Console.WriteLine("");
                Console.WriteLine("You are joining us tonight in " + VenueName + ", The crowd is at a whopping " + crowdSize + " person!");
                Console.WriteLine("");
            }
            else
            {
            Console.WriteLine("");
            Console.WriteLine("You are joining us tonight in " + VenueName + ", The crowd is at a whopping " + crowdSize + " people!");
            Console.WriteLine("");
            }
        }
    }
}
