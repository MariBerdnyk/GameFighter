using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFighter.Models
{
    public abstract class Person
    {
        public int Health { get; set; }

        public bool IsAlive { get => Health > 0; }

        public virtual void GetAttack(Warrior warrior)
        {
            Health -= warrior.Attack;
        }
    }
}
