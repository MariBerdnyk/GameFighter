using GameFighter.Models;
using GameFighter.Weapons;

namespace GameFighter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var chuck = new Warrior();
            //var bruce = new Warrior();
            //var carl = new Knight();
            //var dave = new Warrior();

            //Console.WriteLine(Battle.Fight(chuck, bruce));
            //Console.WriteLine(Battle.Fight(dave, carl));

            //Console.WriteLine("Are alive:");
            //Console.WriteLine("\t" + chuck.IsAlive);
            //Console.WriteLine("\t" + bruce.IsAlive);
            //Console.WriteLine("\t" + carl.IsAlive);
            //Console.WriteLine("\t" + dave.IsAlive);

            //Console.WriteLine("Health:");
            //Console.WriteLine("\t" + chuck.Health);
            //Console.WriteLine("\t" + bruce.Health);
            //Console.WriteLine("\t" + carl.Health);
            //Console.WriteLine("\t" + dave.Health);

            //var army1 = new Army();
            //var army2 = new Army();

            //army1.AddUnits<Defender>(5);
            //army1.AddUnits<Vampire>(6);
            //army1.AddUnits<Warrior>(7);

            //army2.AddUnits<Warrior>(6);
            //army2.AddUnits<Defender>(6);
            //army2.AddUnits<Vampire>(6);

            //Battle.Fight(army1, army2);

            //var army1 = new Army();
            //var army2 = new Army();

            //army1.AddUnits<Lancer>(7);

            //army2.AddUnits<Warrior>(4);
            //army2.AddUnits<Defender>(4);
            //army2.AddUnits<Healer>(1);

            //Console.WriteLine(Battle.Fight(army1, army2));

            //var defender = new Defender();
            //var vampire = new Vampire();

            //defender.EquipWeapon(new Shield());
            //defender.EquipWeapon(new MagicWand());
            //vampire.EquipWeapon(new Shield());
            //vampire.EquipWeapon(new Katana());

            //Battle.Fight(defender, vampire);
            Army army1 = null;
            Army army2 = null;

            Battle.Fight(army1, army2);
        }
    }
}
