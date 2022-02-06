using GameFighter.Models;

namespace GameFighter
{
    public class Knight : Warrior
    {
        public Knight()
        {
            Attack = 7;
        }

        public override void CreateNewModel(ref Warrior unit) => unit = new Knight();
    }
}
