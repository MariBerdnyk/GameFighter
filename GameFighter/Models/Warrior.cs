using GameFighter.Models;
using GameFighter.Weapons;
using System;

namespace GameFighter
{
    public class Warrior : Person
    {
        public int Attack { get; protected set; }

        public int DefaultAttack { get; protected set; }

        public Warrior()
        {
            Health = 50;
            Attack = 5;

            MaxHealth = Health;
            DefaultAttack = Attack;
        }

        public virtual void NextAbility()
        {
            Next?.UniqueOption(this);
        }

        public override void Attacks(Warrior warrior, Army thisArmy)
        {
            //NextAbility();
            thisArmy?.AvokeUnitsNextAbility();

            warrior.GetAttack(Attack);
        }

        public virtual int GetAttack(int attack)
        {
            int beforeFightHealth = Health;

            Health -= attack;

            if (Health <= 0)
            {
                Next.PrepareForBattle(this);
            }

            return Health > 0 ? beforeFightHealth - Health : beforeFightHealth;
        }

        public override void EquipWeapon(Weapon weapon)
        {
            base.EquipWeapon(weapon);

            if(DefaultAttack == 0)
            {
                return;
            }

            int plus = Math.Max(Attack + weapon.AttackParametr, 0);
            Attack = plus;
            unitsWeapons.Add(weapon);
        }
    }
}
