using System.Collections.Generic;

namespace GameFighter.Models
{
    public class Army
    {
        public List<Warrior> ArmyMembers { get; private set; } = new List<Warrior>();

        public int CountUnits => ArmyMembers.Count;

        public bool IsSomeUnitAlive
        {
            get
            {
                foreach (var item in ArmyMembers)
                {
                    if (item.IsAlive)
                    {
                        return true;
                    }
                }
                return false;
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
