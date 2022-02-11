﻿namespace GameFighter.Models
{
    public class Defender : Warrior
    {
        public int Defence { get; protected set; }

        public Defender()
        {
            Health = 60;
            Attack = 3;
            Defence = 2;
        }

        public override int GetAttack(int attack)
        {
            int beforeFightHealth = Health;

            if (attack >= Defence)
            {
                Health -= attack - Defence;
            }

            return Health > 0 ? beforeFightHealth - Health : beforeFightHealth;
        }
    }
}
