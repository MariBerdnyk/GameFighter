namespace GameFighter
{
    public class Warrior
    {
        public int Health { get; init; }
        public int Attack { get; init; } = default;
        public bool Alive { get; private set; }
        public Warrior()
        {
            Health = 50;
            Attack = 5;
            Alive = true;
        }
        public bool Fight(Warrior warrior)
        {
            //while (warrior.Health > 0 && Health > 0)
            //{
            //    warrior.Health -= Attack;
            //    if (warrior.Health <= 0)
            //    {
            //        warrior.Alive = false;
            //        break;
            //    }
            //    Health -= warrior.Attack;
            //    Alive = health > 0;
            //}
            return Alive;
        }
    }
}
