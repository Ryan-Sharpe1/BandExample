using System;
using System.Collections.Generic;
namespace BandExample
{
    public class Band
    {

        public List<Musician> Musicians = new List<Musician>();
        string Name;

        public void AddBand()
        {
            int bandCount = 0;
            int musicianCount = 0;
            Console.WriteLine("What is the name of your band?");
            Console.WriteLine("");
            Name = Console.ReadLine();
            Console.WriteLine("");


            Console.WriteLine("How many people are in your band?");
            Console.WriteLine("");
            int numberInBand = 0;
            if (!int.TryParse(Console.ReadLine(), out numberInBand))
            {
                Console.WriteLine("input was not valid");
                Environment.Exit(0);
            }

            if (bandCount == 0)
            {
                Console.WriteLine("");
                Console.WriteLine(Name + " has " + numberInBand + " members.");
                Console.WriteLine("");
                bandCount++;
            }
            while (musicianCount < numberInBand)
            {
                AddMusician();
                musicianCount++;
            }
        }

        public void AddMusician()
        {
            Musician musician = new Musician();
            Console.WriteLine("What is the name of the musician to be added?");
            Console.WriteLine("");
            musician.Name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("What instrument does " + musician.Name + " play?");
            Console.WriteLine("");
            musician.Instrument = Console.ReadLine();
            Console.WriteLine("");
            Musicians.Add(musician);
        }
        public void Announce()
        {
            int bandCount = 0;
            string BandName = Name;
            if (bandCount == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Everyone please put your hands together for " + BandName + "!");
                bandCount++;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Up next we have " + Name);
            }

            foreach (var musician in Musicians)
            {
                musician.Announce();
            }
            Console.WriteLine("Let's rock and roll!");
            Console.WriteLine("");
        }

    }
}
