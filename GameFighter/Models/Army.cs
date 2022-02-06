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
                unit.CreateNewModel(ref unit);

                ArmyMembers.Add(unit);
                number--;
            }
        }
    }
}
