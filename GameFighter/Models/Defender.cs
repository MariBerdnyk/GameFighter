using GameFighter.Weapons;
using System;

namespace GameFighter.Models
{
    public class Defender : Warrior
    {
        public int Defence { get; protected set; }

        public Defender()
        {
            Health = 60;
            Attack = 3;
            Defence = 2;

            MaxHealth = Health;
            DefaultHealth = MaxHealth;
            ChangedAttack = Attack;
            DefaultAttack = ChangedAttack;
        }

        public override int GetAttack(int attack)
        {
            int beforeFightHealth = Health;

            if (attack >= Defence)
            {
                Health -= attack - Defence;
            }

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

            int plus = Math.Max(Defence + weapon.DefenceParametr, 0);
            Defence = plus;
            unitsWeapons.Add(weapon);
        }
    }
}
