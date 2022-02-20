using GameFighter.Models;

namespace GameFighterXUnitTests
{
    internal class Rookie : Warrior
    {
        public Rookie()
        {
            Attack = 1;
            ChangedAttack = Attack;
            DefaultAttack = ChangedAttack;
        }
    }
}
