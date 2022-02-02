namespace GameFighter
{
    public class Warrior
    {
        public int Health { get; private set; }
        public int Attack { get; init; }
        public bool Alive { get; private set; }
        public Warrior()
        {
            Health = 50;
            Attack = 5;
            Alive = true;
        }
        public bool Fight(int attack)
        {
            Health -= attack;
            if (Health <= 0)
                Alive = false;
            return Alive;
        }
    }
}
