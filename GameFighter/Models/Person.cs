using System;
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

            if (Health > 0)
            {
                return beforeFightHealth - Health;
            }

            return beforeFightHealth;
        }
        //public virtual void GetAttack(Warrior warrior)
        //{
        //    Health -= warrior.Attack;
        //}
    }
}
