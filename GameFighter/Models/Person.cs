﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFighter.Models
{
    public abstract class Person
    {
        public int Health { get; protected set; }

        public bool IsAlive => Health > 0;

        protected int MaxHealth = default;

        public virtual int GetAttack(int attack)
        {
            int beforeFightHealth = Health;
            
            Health -= attack;

            return Health > 0 ? beforeFightHealth - Health : beforeFightHealth;
        }

        public abstract void Attacks(Warrior warrior, Army warriorsArmy, Army thisArmy);
    }
}
