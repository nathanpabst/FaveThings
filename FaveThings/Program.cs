using System;
using FaveThings.Bands;

namespace FaveThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var theShins = new TheShins();
            theShins.PrintMembers();
            theShins.PrintAlbums();
            theShins.Touring();
            Console.WriteLine();

            var fleetFoxes = new FleetFoxes();
            fleetFoxes.PrintMembers();
            fleetFoxes.PrintAlbums();
            fleetFoxes.Touring();
            Console.WriteLine();

            var ledZeppelin = new LedZeppelin();
            ledZeppelin.PrintMembers();
            ledZeppelin.PrintAlbums();
            ledZeppelin.Touring();
            Console.WriteLine();

            var fatherJohnMisty = new FatherJohnMisty();
            fatherJohnMisty.PrintMembers();
            fatherJohnMisty.PrintAlbums();
            fatherJohnMisty.Touring();

            Console.WriteLine("press enter to exit.");
            Console.ReadLine();
        }
    }
}
