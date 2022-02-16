using GameFighter.Weapons;

namespace GameFighter.Models
{
    public class Healer : Warrior
    {
        public int Heal { get; protected set; }

        public int NumberOfKit { get; protected set; }

        public Healer()
        {
            Attack = 0;
            Health = 60;
            Heal = 2;

            MaxHealth = 60;
        }

        public override void PrepareForBattle()
        {
            NumberOfKit = 10;
        }

        public override void UniqueOption(Warrior warrior)
        {
            if (warrior.Health == warrior.MaxHealth || NumberOfKit <= 0)
            {
                return;
            }

            if (warrior.Health + Heal <= warrior.MaxHealth)
            {
                warrior.Health += Heal;
                NumberOfKit--;
            }
            else
            {
                warrior.Health = warrior.MaxHealth;
                NumberOfKit--;
            }
        }

        public override void EquipWeapon(Weapon weapon)
        {
            base.EquipWeapon(weapon);

            if (Heal + weapon.HealParametr < 0)
            {
                Heal = 0;
                return;
            }

            Heal += weapon.HealParametr;
        }
    }
}
