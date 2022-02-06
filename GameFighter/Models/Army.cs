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

        public void AddUnits(Warrior unit, int number)
        {
            while (number > 0)
            {
                if (unit is Knight)
                {
                    unit = new Knight();
                }
                else
                {
                    unit = new Warrior();
                }

                ArmyMembers.Add(unit);
                number--;
            }
        }
    }
}
