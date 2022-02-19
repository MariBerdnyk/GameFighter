using System.Collections.Generic;
using System.Linq;

namespace GameFighter.Models
{
    public class Army
    {
        public readonly List<Warrior> ArmyMembers = new ();

        public int CountUnits => ArmyMembers.Count;

        public bool HasAliveUnit => ArmyMembers.Any(x => x.IsAlive);
        
        public bool HasWarlord => ArmyMembers.Any(x => x is Warlord);

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
            ArmyMembers.ForEach(x => x.NextAbility());
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
