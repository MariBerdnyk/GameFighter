using System;

namespace GameFighter.Models
{
    public class Lancer : Warrior
    {
        public Lancer()
        {
            Attack = 6;
        }

        public override void Attacks(Warrior warrior, Army thisArmy)
        {
            //NextAbility();
            thisArmy?.AvokeUnitsNextAbility();
            var actualAttack = warrior.GetAttack(Attack);

            var unitAfter = warrior.Next;

            while (unitAfter != null && !unitAfter.IsAlive)
            {
                unitAfter = unitAfter.Next;
            }

            unitAfter?.GetAttack(actualAttack * 50 / 100);
        }
    }
}
