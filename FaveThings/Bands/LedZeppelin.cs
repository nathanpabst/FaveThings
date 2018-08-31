using System;


namespace FaveThings.Bands
{
    class LedZeppelin
    {
        public int Members { get; private set; } = 4;
        public int Albums { get; private set; } = 9;
        public bool isTouring { get; private set; } = false;

        public void PrintMembers()
        {
            Console.WriteLine($"Led Zeppelin has {Members} members.");
        }

        public void PrintAlbums()
        {
            Console.WriteLine($"They have {Albums} studio albums.");
        }

        public void Touring()
        {
            if (isTouring)
            {
                Console.WriteLine("And they are still touring today.");
            }
            else
            {
                Console.WriteLine("But they are no longer touring.");
            }
        }
    }
}
