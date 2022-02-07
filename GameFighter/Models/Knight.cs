using GameFighter.Models;

namespace GameFighter
{
    public class Knight : Warrior
    {
        public Knight()
        {
            Attack = 7;
        }

        public override Warrior CreateNewUnit()
        {
            return new Knight();
        }
    }
}
