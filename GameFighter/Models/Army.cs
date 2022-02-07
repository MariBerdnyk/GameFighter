using System.Collections.Generic;

namespace GameFighter.Models
{
    public class Army
    {
        public readonly List<Warrior> ArmyMembers = new List<Warrior>();

        public int CountUnits => ArmyMembers.Count;

        public bool HasAliveUnit
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
                unit = new();

                ArmyMembers.Add(unit);
                number--;
            }
        }
    }
}
