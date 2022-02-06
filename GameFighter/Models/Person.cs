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

        public virtual void GetAttack(Warrior warrior)
        {
            Health -= warrior.Attack;
        }

        abstract public void CreateNewModel(ref Warrior unit);
    }
}
