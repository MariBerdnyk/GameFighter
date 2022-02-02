namespace GameFighter
{
    public class Warrior
    {
        public int Health { get; private set; }
        public int Attack { get; protected set; }
        public bool Alive { get => Health > 0 ? true : false; }
        public Warrior()
        {
            Health = 50;
            Attack = 5;
        }
        public void Hit(int attack)
        {
            Health -= attack;
        }
    }
}
