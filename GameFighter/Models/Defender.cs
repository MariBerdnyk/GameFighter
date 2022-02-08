namespace GameFighter.Models
{
    public class Defender : Warrior
    {
        public int Defence { get; protected set; }

        public Defender()
        {
            Health = 60;
            Attack = 3;
            Defence = 2;
        }

        public override int GetAttack(Warrior warrior)
        {
            int beforeFightHealth = Health;

            if (warrior.Attack >= Defence)
            {
                Health -= warrior.Attack - Defence;
            }

            if (Health > 0)
            {
                return beforeFightHealth - Health;
            }

            return beforeFightHealth;
        }
    }
}
