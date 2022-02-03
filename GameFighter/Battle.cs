namespace GameFighter
{
    public static class Battle
    {
        public static bool Fight(Warrior warrior_1, Warrior warrior_2)
        {
            while(warrior_1.Alive)
            {
                warrior_2.Hit(warrior_1.Attack);
                if (!warrior_2.Alive)
                    return true;
                warrior_1.Hit(warrior_2.Attack);
            }
            return false;
        }
    }
}
