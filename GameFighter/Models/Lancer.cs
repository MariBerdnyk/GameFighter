namespace GameFighter.Models
{
    public class Lancer : Warrior
    {
        public Lancer()
        {
            Attack = 6;

            DefaultAttack = Attack;
        }

        public override void Attacks(Warrior warrior, Army thisArmy)
        {
            thisArmy?.AvokeUnitsNextAbility();
            var actualAttack = warrior.GetAttack(Attack);

            warrior.Next?.GetAttack(actualAttack * 50 / 100);
        }
    }
}
