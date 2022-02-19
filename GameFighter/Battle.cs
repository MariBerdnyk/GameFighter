﻿using GameFighter.Models;
using System;
using System.Linq;

namespace GameFighter
{
    public static class Battle
    {
        public static bool Fight(Warrior warrior1, Warrior warrior2, Army army1 = null, Army army2 = null)
        {
            if (warrior1 == null || warrior2 == null)
            {
                throw new ArgumentNullException("warrior1 and warrior2 must be initialised!");
            }

            if (!warrior1.IsAlive || !warrior2.IsAlive)
            {
                throw new ArgumentException($"{warrior1} and {warrior2} must be alive!");
            }

            while (warrior1.IsAlive)
            {
                Console.WriteLine();
                Console.Write(warrior1 + " | "+ warrior1.Health + "\t" + warrior2 + " | " + warrior2.Health);
                Console.WriteLine();
                warrior1.Attacks(warrior2, army1);

                Console.Write(warrior1 + " | " + warrior1.Health + "\t" + warrior2 + " | " + warrior2.Health);

                if (!warrior2.IsAlive)
                {
                    return true;
                }
                
                warrior2.Attacks(warrior1, army2);
                Console.WriteLine();
                Console.Write(warrior1 + " | " + warrior1.Health + "\t" + warrior2 + " | " + warrior2.Health);
            }
            Console.WriteLine();
            Console.Write(warrior1 + " | " + warrior1.Health + "\t" + warrior2 + " | " + warrior2.Health);
            return false;
        }

        public static bool Fight(Army army1, Army army2)
        {
            if (army1 == null || army2 == null)
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

            if (army1.ArmyMembers[0].Attack <= 0 && army2.ArmyMembers[0].Attack <= 0)
            {
                throw new Exception("First units must be able to attack!");
            }

            army1.PrepareArmyForBattle();
            army2.PrepareArmyForBattle();

            foreach (var item in army1.ArmyMembers)
            {
                if (item.IsAlive)
                {
                    foreach (var item2 in army2.ArmyMembers)
                    {
                        if (item2.IsAlive && !Fight(item, item2, army1, army2))
                        {
                            break;
                        }
                    }
                }
            }
            return army1.HasAliveUnit;
        }

        public static bool StraightFight(Army army1, Army army2)
        {
            if (army1 == null || army2 == null)
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

            if (army1.ArmyMembers[0].Attack <= 0 && army2.ArmyMembers[0].Attack <= 0)
            {
                throw new Exception("First units must be able to attack!");
            }

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
