namespace GameFighter.Models
{
    public class Lancer : Warrior
    {
        public Lancer()
        {
            Attack = 6;
        }

        public override void Attacks(Warrior warrior, Army warriorsArmy)
        {
            var actualAttack = warrior.GetAttack(Attack);

            if (warriorsArmy != null && warriorsArmy.Next(warrior) != null)
            {
                warriorsArmy.Next(warrior).GetAttack(actualAttack * 50 / 100);
            }
        }
    }
}
