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


        public virtual int GetAttack(Warrior warrior)
        {
            int beforeFightHealth = Health;
            
            Health -= warrior.Attack;

            return Health > 0 ? beforeFightHealth - Health : beforeFightHealth;
        }

        public abstract void Attacks(Warrior warrior);
    }
}
