using GameFighter.Weapons;
using System;

namespace GameFighter.Models
{
    public class Archer : Warrior
    {
        public int RangedAttack { get; protected set; }

        public Archer()
        {
            Health = 40;
            Attack = 2;
            RangedAttack = 5;

            MaxHealth = Health;
            DefaultHealth = MaxHealth;
            ChangedAttack = Attack;
            DefaultAttack = ChangedAttack;
        }

        public override void UniqueOption(Warrior warrior)
        {
            if (IsAlive && warrior.Attack == warrior.ChangedAttack)
            {
                warrior.Attack += RangedAttack;
            }
        }

        public override void PrepareForBattle(Warrior warrior)
        {
            foreach (var item in warrior.unitsWeapons)
            {
                EquipWeapon(item);
            }
        }

        public override void EquipWeapon(Weapon weapon)
        {
            base.EquipWeapon(weapon);

            int plus = Math.Max(RangedAttack + weapon.RangedAttackParametr, 0);
            RangedAttack = plus;
        }
        public override string ToString()
        {
            return "Archer" + " | Attack: " + Attack + " | Health: " + Health;
        }
    }
}
