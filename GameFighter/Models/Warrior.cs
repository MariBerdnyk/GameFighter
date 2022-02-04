namespace GameFighter
{
    public class Warrior
    {
        public int Health { get; set; }

        public int Attack { get; protected set; }

        public bool IsAlive { get => Health > 0; }

        public Warrior()
        {
            Health = 50;
            Attack = 5;
        }

        public void GetAttack(int attack)
        {
            Health -= attack;
        }
    }
}
