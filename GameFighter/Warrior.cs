using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFighter
{
    public class Warrior
    {
        public int health = default;
        private int attack = default;
        public bool Alive { get; set; }
        public Warrior()
        {
            health = 50;
            attack = 5;
            Alive = true;
        }
        public bool Fight(Warrior warrior)
        {
            while(warrior.health > 0 && health > 0)
            {
                warrior.health -= attack;
                health -= warrior.attack;
                Alive = health > 0;
            }
            return Alive;
        }
    }
}
