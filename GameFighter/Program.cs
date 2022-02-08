using GameFighter.Models;
using System;

namespace GameFighter
{
    class Program
    {
        static void Main(string[] args)
        {
            var chuck = new Warrior();
            var bruce = new Warrior();
            var carl = new Knight();
            var dave = new Warrior();

            Console.WriteLine(Battle.Fight(chuck, bruce));
            Console.WriteLine(Battle.Fight(dave, carl));

            Console.WriteLine("Are alive:");
            Console.WriteLine("\t" + chuck.IsAlive);
            Console.WriteLine("\t" + bruce.IsAlive);
            Console.WriteLine("\t" + carl.IsAlive);
            Console.WriteLine("\t" + dave.IsAlive);

            Console.WriteLine("Health:");
            Console.WriteLine("\t" + chuck.Health);
            Console.WriteLine("\t" + bruce.Health);
            Console.WriteLine("\t" + carl.Health);
            Console.WriteLine("\t" + dave.Health);

            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Defender>(5);
            army1.AddUnits<Vampire>(6);
            army1.AddUnits<Warrior>(7);

            army2.AddUnits<Warrior>(6);
            army2.AddUnits<Defender>(6);
            army2.AddUnits<Vampire>(6);

            Battle.Fight(army1, army2);
        }
    }
}
