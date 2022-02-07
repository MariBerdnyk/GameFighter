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
                warrior2.GetAttack(warrior1);
                if (!warrior2.IsAlive)
                {
                    return true;
                }

                warrior1.GetAttack(warrior2);
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

            if (army1.GetAliveUnitPosition == -1 || army2.GetAliveUnitPosition == -1)
            {
                throw new ArgumentException($"{army1} and {army2} must have alive units!");
            }

            for (int i = 0, j = 0; i < army1.CountUnits && j <= army2.CountUnits;)
            {
                if (j == army2.CountUnits)
                {
                    return true;
                }


                if(!army1.ArmyMembers[i].IsAlive)
                {
                    i++;
                    continue;
                }

                if (!army2.ArmyMembers[j].IsAlive)
                {
                    j++;
                    continue;
                }

                if (Fight(army1.ArmyMembers[i], army2.ArmyMembers[j]))
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }
            
            return false;
        }
    }
}
