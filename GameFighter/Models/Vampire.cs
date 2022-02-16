using System;

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

            MaxHealth = 40;
        }

        public override void Attacks(Warrior warrior, Army thisArmy, bool isStraightBattle)
        {
            thisArmy?.AvokeUnitsNextAbility();
            //NextAbility();

            int actualAttack = warrior.GetAttack(Attack);

            if (Health + actualAttack * Vampirism / 100 < MaxHealth)
            {
                Health += actualAttack * Vampirism / 100;
            }
            else
            {
                Health = MaxHealth;
            }
        }
    }
}
