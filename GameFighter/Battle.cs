using GameFighter.Models;
using System;
using System.Linq;

namespace GameFighter
{
    public static class Battle
    {
        private static void ValidatingUnits(Warrior warrior1, Warrior warrior2)
        {
            if (warrior1 == null || warrior2 == null)
            {
                throw new ArgumentNullException("warrior1 and warrior2 must be initialised!");
            }

            if (!warrior1.IsAlive || !warrior2.IsAlive)
            {
                throw new ArgumentException($"{warrior1} and {warrior2} must be alive!");
            }

            if (warrior1.Attack <= 0 && warrior2.Attack <= 0)
            {
                throw new Exception("First units must be able to attack!");
            }
        }

        private static void ValidatingArmy(Army army1, Army army2)
        {
            if(army1 == null || army2 == null)
            {
                throw new ArgumentNullException("army1 and army2 must be initialised!");
            }

            if (army1.CountUnits == 0 || army2.CountUnits == 0)
            {
                throw new ArgumentException($"{army1} and {army2} must have units!");
            }

            if (!army1.HasAliveUnit || !army2.HasAliveUnit)
            {
                throw new ArgumentException($"{army1} and {army2} must have alive units!");
            }
        }

        public static bool Fight(Warrior warrior1, Warrior warrior2, Army army1 = null, Army army2 = null)
        {
            ValidatingUnits(warrior1, warrior2);
            Console.WriteLine();
            Console.WriteLine("__________Round: " + round + "__________");
            while (warrior1.IsAlive)
            {
                Console.WriteLine();
                Console.WriteLine("Before start:");
                Console.WriteLine (warrior1 + "\tVs\t" + warrior2);
                Console.WriteLine(warrior1.Next + "\t  \t" + warrior2.Next);
                warrior1.Attacks(warrior2, army1);

                Console.WriteLine();
                Console.WriteLine("After attack first:");
                Console.WriteLine(warrior1 + "\tVs\t" + warrior2);
                Console.WriteLine(warrior1.Next + "\t  \t" + warrior2.Next);

                if (!warrior2.IsAlive)
                {
                    return true;
                }
                warrior2.Attacks(warrior1, army2);
                Console.WriteLine();
                Console.WriteLine("After attack second:");
                Console.WriteLine(warrior1 + "\tVs\t" + warrior2);
                Console.WriteLine(warrior1.Next + "\t  \t" + warrior2.Next);
            }
            return false;
        }
        static int round = 1;
        public static bool Fight(Army army1, Army army2)
        {
            ValidatingArmy(army1, army2);
            Console.WriteLine("_________Army 1 members:__________");
            army1.Print();
            Console.WriteLine();
            Console.WriteLine("_________Army 2 members:__________");
            army2.Print();

            Console.WriteLine();
            Console.WriteLine("_________Army 1 after mooving:__________");
            army1.PrepareArmyForBattle();
            Console.WriteLine();
            Console.WriteLine("_________Army 2 after mooving:__________");
            army2.PrepareArmyForBattle();
            for (int i = 0; i < army1.CountUnits; i++)
            {
                if (army1[i].IsAlive)
                {
                    for (int j = 0; j < army2.CountUnits; j++)
                    {
                        bool isUnitAlive = army2[j].IsAlive;
                        
                        if (isUnitAlive && !Fight(army1[i], army2[j], army1, army2))
                        {
                            Console.WriteLine("_________Army 1 after mooving:__________");
                            army1.MoveUnits();
                            Console.WriteLine();
                            Console.WriteLine("_________Army 2 after mooving:__________");
                            army2.MoveUnits();
                            i = -1;
                            round++;
                            break;
                        }

                        else if(isUnitAlive)
                        {
                            Console.WriteLine("_________Army 1 after mooving:__________");
                            army1.MoveUnits();
                            Console.WriteLine();
                            Console.WriteLine("_________Army 2 after mooving:__________");
                            army2.MoveUnits();
                            j = -1;
                            round++;
                        }
                    }
                }
            }

            return army1.HasAliveUnit;
        }

        public static bool StraightFight(Army army1, Army army2)
        {
            ValidatingArmy(army1, army2);

            army1.PrepareArmyForStraightBattle();
            army2.PrepareArmyForStraightBattle();

            do
            {
                foreach (var (first, second) in army1.ArmyMembers.Where(x => x.IsAlive).Zip(army2.ArmyMembers.Where(x => x.IsAlive)))
                {
                    Fight(first, second);
                }

            } while (army1.HasAliveUnit && army2.HasAliveUnit);

            return army1.HasAliveUnit;
        }
    }
}
