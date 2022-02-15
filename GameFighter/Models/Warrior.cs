using GameFighter.Models;
using System;

namespace GameFighter
{
    public class Warrior : Person
    {
        public int Attack { get; protected set; }

        public Warrior()
        {
            Health = 50;
            Attack = 5;
            MaxHealth = 50;
        }

       

        public override void Attacks(Warrior warrior, Army warriorsArmy, Army thisArmy)
        {
            thisArmy?.Next(this)?.UniqueOption(this);
            warrior.GetAttack(Attack);
        }
    }
}
