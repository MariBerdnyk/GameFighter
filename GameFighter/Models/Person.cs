﻿using GameFighter.Weapons;
using System;
using System.Collections.Generic;

namespace GameFighter.Models
{
    public abstract class Person
    {
        public readonly List<Weapon> unitsWeapons = new();

        public int Health { get; protected internal set; }

        public bool IsAlive => Health > 0;

        public int MaxHealth { get; protected internal set; }

        public int DefaultHealth { get; protected set; }

        public Warrior Next { get; set; } = default;

        public virtual void PrepareForBattle() { }

        public virtual void PrepareForBattle(Warrior warrior) { }

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

        public abstract void Attacks(Warrior warrior, Army thisArmy);
    }
}
