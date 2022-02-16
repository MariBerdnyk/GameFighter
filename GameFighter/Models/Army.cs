using System.Collections.Generic;
using System.Linq;

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

        public void AvokeUnitsNextAbility()
        {
            foreach (var item in ArmyMembers)
            {
                item.NextAbility();
            }
        }

        public void AddUnits<T>(int number) where T : Warrior, new()
        {
            while (number > 0)
            {
                T unit = new();

                if (CountUnits > 0)
                {
                    ArmyMembers[CountUnits - 1].Next = unit;
                }

                ArmyMembers.Add(unit);
                number--;
            }
        }
    }
}
