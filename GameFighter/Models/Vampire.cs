﻿namespace GameFighter.Models
{
    public class Vampire : Warrior
    {
        public int Vampirism { get; protected set; }

        public Vampire()
        {
            Health = 40;
            Attack = 4;
            Vampirism = 50;
        }

        public override void Attacks(Warrior warrior, Warrior warrior1 = null)
        {
            int actualAttack = warrior.GetAttack(Attack);

            Health += actualAttack * Vampirism / 100;
        }
    }
}
