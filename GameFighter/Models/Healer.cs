using GameFighter.Weapons;
using System;

namespace GameFighter.Models
{
    public class Healer : Warrior
    {
        public int Heal { get; protected set; }

        public int NumberOfKit { get; protected set; }

        public Healer()
        {
            Attack = 0;
            Health = 60;
            Heal = 2;

            MaxHealth = Health;
            DefaultAttack = Attack;
        }

        public override void PrepareForBattle()
        {
            NumberOfKit = 10;
        }

        public override void UniqueOption(Warrior warrior)
        {
            if (warrior.Health == warrior.MaxHealth || NumberOfKit <= 0)
            {
                return;
            }

            int plus = Math.Min(warrior.Health + Heal, warrior.MaxHealth);
            warrior.Health = plus;
            NumberOfKit--;
        }

        public override void EquipWeapon(Weapon weapon)
        {
            base.EquipWeapon(weapon);

            int plus = Math.Max(Heal + weapon.HealParametr, 0);
            Heal = plus;
            unitsWeapons.Add(weapon);
        }
    }
}
