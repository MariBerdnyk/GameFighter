namespace GameFighter
{
    public static class Battle
    {
        public static bool Fight(Warrior warrior_1, Warrior warrior_2)
        {

            while(warrior_1.Alive && warrior_2.Alive)
            {
                if (warrior_2.Fight(warrior_1.Attack))
                    warrior_1.Fight(warrior_2.Attack);
            }
            return warrior_1.Alive;
        }
    }
}
