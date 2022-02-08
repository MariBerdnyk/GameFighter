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

        public void Healing(int actualAttack)
        {
            Health += actualAttack * Vampirism / 100;
        }
    }
}
