using GameFighter.Models;
using GameFighter.Weapons;
using System;

namespace GameFighter
{
    public class Warrior : Person
    {
        public int Attack { get; protected set; }

        public Warrior()
        {
            Health = 50;
            Attack = 5;
            MaxHealth = 50;
        }

        public virtual void NextAbility()
        {
            Next?.UniqueOption(this);
        }

        public override void Attacks(Warrior warrior, Army thisArmy, bool isStraightBattle)
        {
            //NextAbility();
            thisArmy?.AvokeUnitsNextAbility();

            warrior.GetAttack(Attack);
        }

        public override void EquipWeapon(Weapon weapon)
        {
            base.EquipWeapon(weapon);

            if(Attack + weapon.AttackParametr < 0)
            {
                Attack = 0;
                return;
            }

            Attack += weapon.AttackParametr;
        }
    }
}
