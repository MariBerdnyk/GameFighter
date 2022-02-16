using GameFighter.Weapons;

namespace GameFighter.Models
{
    public class Defender : Warrior
    {
        public int Defence { get; protected set; }

        public Defender()
        {
            Health = 60;
            Attack = 3;
            Defence = 2;
            MaxHealth = 60;
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

        public override void EquipWeapon(Weapon weapon)
        {
            base.EquipWeapon(weapon);

            if (Defence + weapon.DefenceParametr < 0)
            {
                Defence = 0;
                return;
            }

            Defence += weapon.DefenceParametr;
        }
    }
}
