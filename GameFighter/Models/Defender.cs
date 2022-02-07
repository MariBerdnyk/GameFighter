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

        public override void GetAttack(Warrior warrior)
        {
            if (warrior.Attack >= Defence)
            {
                Health -= (warrior.Attack - Defence);
            }
        }
    }
}
