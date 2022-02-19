using System.Collections.Generic;
using System.Linq;

namespace GameFighter.Models
{
    public class Army
    {
        public List<Warrior> ArmyMembers { get; private set; } = new();

        public int CountUnits => ArmyMembers.Count;

        public bool HasAliveUnit => ArmyMembers.Any(x => x.IsAlive);
        
        public Warlord FindWarlord
        {
            get
            {
                var warlord = (Warlord)ArmyMembers.FirstOrDefault(x => x is Warlord);
                return warlord;
            }
        }
        public void MoveUnits()
        {
            var units = FindWarlord?.MoveUnits(ArmyMembers);
            if (units != null)
            {
                ArmyMembers = units;
            }
            SetNextArmy();
        }

        public void MoveUnitsStraightBattle()
        {
            var units = FindWarlord?.MoveUnits(ArmyMembers);
            if (units != null)
            {
                ArmyMembers = units;
            }
        }

        public void PrepareArmyForBattle()
        {
            MoveUnits();
            for (int i = 1; i < CountUnits; i++)
            {
                ArmyMembers[i - 1].PrepareForBattle();
            }
        }

        private void SetNextArmy()
        {
            for (int i = 1; i < CountUnits; i++)
            {
                SetNext(i);
            }
            ArmyMembers[CountUnits - 1].Next = null;
        }

        private void SetNext(int index)
        {
            ArmyMembers[index - 1].Next = ArmyMembers[index];
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

                if (unit is Warlord && FindWarlord != null)
                {
                    return;
                }

                ArmyMembers.Add(unit);
                number--;
            }
        }
    }
}
