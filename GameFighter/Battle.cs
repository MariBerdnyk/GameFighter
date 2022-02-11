using GameFighter.Models;
using System;

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

            while(warrior1.IsAlive)
            {
                warrior1.Attacks(warrior2, army2, army1);

                if (!warrior2.IsAlive)
                {
                    return true;
                }
                warrior2.Attacks(warrior1, army1, army2);
            }
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
    }
}
