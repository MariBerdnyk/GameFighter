using GameFighter.Models;

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

        protected virtual void Healing(Warrior warrior, Army thisArmy)
        {
            if (thisArmy!= null && thisArmy.Next(this) is Healer behindHealer)
            {
                if (Health + behindHealer.Heal > MaxHealth)
                {
                    Health = MaxHealth;
                }
                else
                {
                    Health += behindHealer.Heal;
                }
            }
        }

        public override void Attacks(Warrior warrior, Army warriorsArmy, Army thisArmy)
        {
            Healing(warrior, thisArmy);

            warrior.GetAttack(Attack);
        }
    }
}
