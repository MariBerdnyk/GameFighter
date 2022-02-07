using System.Collections.Generic;

namespace GameFighter.Models
{
    public class Army
    {
        public readonly List<Warrior> ArmyMembers = new List<Warrior>();

        public int CountUnits => ArmyMembers.Count;

        public int GetAliveUnitPosition
        {
            get
            {
                if(CountUnits == 0)
                {
                    return -1;
                }

                int position = 0;
                foreach (var item in ArmyMembers)
                {
                    if (item.IsAlive)
                    {
                        return position;
                    }
                    position++;
                }
                return -1;
            }
        }

        public void AddUnits(Warrior unit, int number)
        {
            while (number > 0)
            {
                unit = new();

                ArmyMembers.Add(unit);
                number--;
            }
        }
    }
}
