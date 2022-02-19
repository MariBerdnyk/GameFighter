using GameFighter.Weapons;
using System;

namespace GameFighter.Models.OwnTask
{
    public class Angel : Warrior
    {
        public Angel()
        {
            Attack = 0;
            DefaultAttack = 0;
            Health = 1;
            MaxHealth = 1;
        }

        public override int GetAttack(int attack)
        {
            return 0;
        }

        public override void Attacks(Warrior warrior, Army thisArmy)
        {
            Health--;
        }

        public override void EquipWeapon(Weapon weapon)
        {
            throw new InvalidOperationException("Angel can't have equipment!");
        }
    }
}
