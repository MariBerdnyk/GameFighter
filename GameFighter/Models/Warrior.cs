using GameFighter.Models;

namespace GameFighter
{
    public class Warrior : Person
    {
        public int Attack { get; protected set; }

        public Warrior()
        {
            Health = 50;
            Attack = 5;
        }

        public override void CreateNewModel(ref Warrior unit) => unit = new Warrior();
    }
}
