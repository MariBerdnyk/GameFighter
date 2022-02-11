﻿using GameFighter.Models;

namespace GameFighter
{
    public class Warrior : Person
    {
        public int Attack { get; protected set; }

        public Warrior()
        {
            Health = 50;
            Attack = 5;
        }

        public override void Attacks(Warrior warrior, Army warriorsArmy = null)
        {
            warrior.GetAttack(Attack);
        }
    }
}
