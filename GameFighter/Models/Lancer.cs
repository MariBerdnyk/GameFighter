namespace GameFighter.Models
{
    public class Lancer : Warrior
    {
        public Lancer()
        {
            Attack = 6;
        }

        public override void Attacks(Warrior warrior, Warrior warriorBehind)
        {
            var actualAttack = warrior.GetAttack(Attack);

            if (warriorBehind != null)
                warriorBehind.GetAttack(actualAttack * 50 / 100);
        }
    }
}
