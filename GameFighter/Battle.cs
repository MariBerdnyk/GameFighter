namespace GameFighter
{
    public static class Battle
    {
        public static bool Fight(Warrior warrior1, Warrior warrior2)
        {
            while(warrior1.IsAlive)
            {
                warrior2.GetAttack(warrior1.Attack);
                if (!warrior2.IsAlive)
                    return true;

                warrior1.GetAttack(warrior2.Attack);
            }
            return false;
        }
    }
}
