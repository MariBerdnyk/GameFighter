namespace GameFighter.Models
{
    public class Warlord : Defender
    {
        public Warlord()
        {
            Health = 100;
            Attack = 4;

            MaxHealth = Health;
            DefaultAttack = Attack;
        }
    }
}
