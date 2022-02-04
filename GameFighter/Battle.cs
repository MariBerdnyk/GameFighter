using System;

namespace GameFighter
{
    public static class Battle
    {
        public static bool Fight(Warrior warrior1, Warrior warrior2)
        {
            if (!warrior1.IsAlive || !warrior2.IsAlive)
                throw new ArgumentException($"{warrior1} and {warrior2} must be alive!");

            while(warrior1.IsAlive)
            {
                warrior2.GetAttack(warrior1);
                if (!warrior2.IsAlive)
                    return true;

                warrior1.GetAttack(warrior2);
            }
            return false;
        }
    }
}
