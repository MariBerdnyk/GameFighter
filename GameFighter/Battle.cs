using GameFighter.Models;
using System;

namespace GameFighter
{
    public static class Battle
    {
        public static bool Fight(Warrior warrior1, Warrior warrior2)
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

                int actualattack = warrior2.GetAttack(warrior1);

                if (warrior1 is Vampire)
                {
                    (warrior1 as Vampire).Healing(actualattack);
                }

                if (!warrior2.IsAlive)
                {
                    return true;
                }

                actualattack = warrior1.GetAttack(warrior2);

                if(warrior2 is Vampire)
                {
                    (warrior2 as Vampire).Healing(actualattack);
                }
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
                        if (item2.IsAlive && !Fight(item, item2))
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
