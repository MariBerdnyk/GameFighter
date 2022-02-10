namespace GameFighter.Models
{
    public class Vampire : Warrior
    {
        public int Vampirism { get; protected set; }

        public Vampire()
        {
            Health = 40;
            Attack = 4;
            Vampirism = 50;
        }

        public override void Attacks(Warrior warrior)
        {
            int actualAttack = warrior.GetAttack(this);

            Health += actualAttack * Vampirism / 100;
        }
    }
}
