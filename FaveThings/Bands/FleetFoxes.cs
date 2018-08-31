using System;


namespace FaveThings.Bands
{
    class FleetFoxes
    {
        public int Members { get; private set; } = 6;

        public int Albums { get; private set; } = 3;

        public bool isTouring { get; private set; } = true;

        public void PrintMembers()
        {
            Console.WriteLine($"The Fleet Foxes have {Members} members.");
        }

        public void PrintAlbums()
        {
            Console.WriteLine($"They have {Albums} studio albums.");
        }

        public void Touring()
        {
            if (isTouring)
            {
                Console.WriteLine("And they are still touring.");
            }
            else
            {
                Console.WriteLine("But they are no longer touring.");
            }
        }
    }
}
