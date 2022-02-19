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

        private void Restock()
        {
            ArmyMembers.ForEach(x => x.PrepareForBattle());
        }

        private void SetNextArmy()
        {
            for (int i = 1; i < CountUnits; i++)
            {
                ArmyMembers[i - 1].Next = ArmyMembers[i];
            }
            ArmyMembers[CountUnits - 1].Next = null;
        }

        private void MoveUnitsStraightBattle()
        {
            var units = FindWarlord?.MoveUnits(ArmyMembers);
            if (units != null)
            {
                ArmyMembers = units;
            }
        }

        public void MoveUnits()
        {
            MoveUnitsStraightBattle();
            SetNextArmy();
        }

        public void PrepareArmyForBattle()
        {
            MoveUnits();
            Restock();
        }

        public void PrepareArmyForStraightBattle()
        {
            MoveUnitsStraightBattle();
            Restock();
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
