using GameFighter.Weapons;
using System;

namespace GameFighter.Models
{
    public class Angel : Warrior
    {
        public Angel()
        {
            Health = 1;
            Attack = 0;

            ChangedAttack = Attack;
            DefaultAttack = ChangedAttack;
            MaxHealth = 1;
        }

        public override int GetAttack(int attack) => 0;

        public override void Attacks(Warrior warrior, Army thisArmy) => Health--;
        

        public override void PrepareForBattle(Warrior warrior)
        {
            if (IsAlive)
            {
                warrior.Health = warrior.MaxHealth * 50 / 100;
                warrior.MaxHealth = warrior.Health;

                Health--;
            }
        }

        public override void EquipWeapon(Weapon weapon) 
            => throw new InvalidOperationException("Angel can't have equipment!");

        public override string ToString()
        {
            return "Angel" + " | Attack: " + Attack + " | Health: " + Health;
        }
    }
}
