using System.Collections;
using System.Collections.Generic;

namespace GameFighter.Models
{
    public class Army
    {
        public List<Warrior> ArmyMembers { get; private set; } = new List<Warrior>();

        public int CountUnits => ArmyMembers.Count;

        public int CountAliveUnits
        {
            get
            {
                int alive = 0;
                foreach (var item in ArmyMembers)
                {
                    if (item.IsAlive)
                    {
                        alive++;
                    }
                }
                return alive;
            }
        }

        public void AddUnits(Warrior warrior, int number)
        {
            while (number > 0)
            {
                warrior = new Warrior();
                ArmyMembers.Add(warrior);
                number--;
            }
        }

        public void AddUnits(Knight knight, int number)
        {
            while (number > 0)
            {
                knight = new Knight();
                ArmyMembers.Add(knight);
                number--;
            }
        } 
    }
}
