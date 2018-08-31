using System;
 

namespace FaveThings.Bands
{
    class FatherJohnMisty
    {
        public int Members { get; private set; } = 8;
        public int Albums { get; private set; } = 4;
        public bool isTouring { get; private set; } = true;

        public void PrintMembers()
        {
            Console.WriteLine($"Father John Misty has {Members} members");
        }

        public void PrintAlbums()
        {
            Console.WriteLine($"He has {Albums} studio albums.");
        }

        public void Touring()
        {
            if (isTouring)
            {
                Console.WriteLine("And he is still touring");
            }
            else
            {
                Console.WriteLine("But he is no longer touring.");
            }

        }
    }
}
