using System.Collections.Generic;
using System.Linq;

namespace GameFighter.Models
{
    public class Army
    {
        public List<Warrior> ArmyMembers { get; private set; } = new();

        public int CountUnits => ArmyMembers.Count;

        public bool HasAliveUnit => ArmyMembers.Any(x => x.IsAlive);
        
        public Warlord FindWarlord => (Warlord)ArmyMembers.FirstOrDefault(x => x is Warlord);

        public void MoveUnits()
        {
            var units = FindWarlord?.MoveUnits(ArmyMembers);
            if (units != null)
            {
                ArmyMembers = units;
            }
        }

        public void PrepareArmyForBattle()
        {
            for (int i = 1; i < CountUnits; i++)
            {
                ArmyMembers[i - 1].PrepareForBattle();
                ArmyMembers[i - 1].Next = ArmyMembers[i];
            }
            MoveUnits();
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
