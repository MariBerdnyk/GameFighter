using GameFighter.Weapons;
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

            MaxHealth = Health;
            DefaultHealth = MaxHealth;
            DefaultAttack = Attack;
        }

        public override void Attacks(Warrior warrior, Army thisArmy)
        {
            thisArmy?.AvokeUnitsNextAbility();

            int actualAttack = warrior.GetAttack(Attack);

            if (Health + actualAttack * Vampirism / 100 < MaxHealth)
            {
                Health += actualAttack * Vampirism / 100;
            }
            else
            {
                Health = MaxHealth;
            }
            Attack = ChangedAttack;
        }
        
        public override void EquipWeapon(Weapon weapon)
        {
            base.EquipWeapon(weapon);

            int plus = Math.Max(Vampirism + weapon.VampirismParametr, 0);
            Vampirism = plus;
            unitsWeapons.Add(weapon);
        }
    }
}
