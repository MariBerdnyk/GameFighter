using GameFighter.Weapons;
using System;

namespace GameFighter.Models
{
    public class Warrior : Person
    {
        public int Attack { get; protected internal set; }

        public int ChangedAttack { get; protected set; }

        public int DefaultAttack { get; protected set; }

        public Warrior()
        {
            Health = 50;
            Attack = 5;

            MaxHealth = Health;
            DefaultHealth = MaxHealth;
            ChangedAttack = Attack;
            DefaultAttack = ChangedAttack;
        }

        public virtual void NextAbility()
        {
            Next?.UniqueOption(this);
        }

        public override void Attacks(Warrior warrior, Army thisArmy)
        {
            thisArmy?.AvokeUnitsNextAbility();

            warrior.GetAttack(Attack);

            Attack = ChangedAttack;
        }

        public virtual int GetAttack(int attack)
        {
            int beforeFightHealth = Health;

            Health -= attack;

            if (Health <= 0)
            {
                Next?.PrepareForBattle(this);
                return beforeFightHealth;
            }

            return beforeFightHealth - Health;
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
            ChangedAttack = plus;
            unitsWeapons.Add(weapon);
        }
    }
}
