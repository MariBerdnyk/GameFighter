﻿using GameFighter.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFighter.Models
{
    public abstract class Person
    {
        public readonly List<Weapon> unitsWeapons = new();

        public int Health { get; protected internal set; }

        public bool IsAlive => Health > 0;

        public int MaxHealth { get; protected set; }

        public Warrior Next { get; set; } = default;

        public virtual void PrepareForBattle() { }

        public virtual int GetAttack(int attack)
        {
            int beforeFightHealth = Health;

            Health -= attack;

            return Health > 0 ? beforeFightHealth - Health : beforeFightHealth;
        }

        public abstract void Attacks(Warrior warrior, Army thisArmy);

        public virtual void UniqueOption(Warrior warrior) { }

        public virtual void EquipWeapon(Weapon weapon)
        {
            if (!IsAlive)
            {
                return;
            }

            int plus = Math.Max(Health + weapon.HealthParametr, 0);
            Health = plus;
            MaxHealth = plus;
            unitsWeapons.Add(weapon);
        }
    }
}
