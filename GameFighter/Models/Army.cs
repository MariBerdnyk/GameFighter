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

        public void PrepareArmyForBattle()
        {
            for (int i = 1; i < CountUnits; i++)
            {
                ArmyMembers[i - 1].PrepareForBattle();
                ArmyMembers[i - 1].Next = ArmyMembers[i];
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

                ArmyMembers.Add(unit);
                number--;
            }
        }
    }
}
