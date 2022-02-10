using System.Collections.Generic;

namespace GameFighter.Models
{
    public class Army
    {
        public readonly List<Warrior> ArmyMembers = new List<Warrior>();

        public int CountUnits => ArmyMembers.Count;

        public int FirstUnitAliveIndex { get; private set; } = -1;

        public void SetAnotherFirstAlive()
        {
            if (FirstUnitAliveIndex + 1 < CountUnits)
            {
                FirstUnitAliveIndex++;
            }
            else
            {
                FirstUnitAliveIndex = -1;
            }
        }

        public Warrior Next()
        {
            if (FirstUnitAliveIndex + 1 >= CountUnits)
            {
                return null;
            }

            for (int i = FirstUnitAliveIndex + 1; i < CountUnits; i++)
            {
                if (ArmyMembers[i].IsAlive)
                {
                    return ArmyMembers[i];
                }
            }

            return null;
        }

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

        public void AddUnits<T>(int number) where T : Warrior, new()
        {
            if (FirstUnitAliveIndex == -1)
            {
                FirstUnitAliveIndex++;
            }

            while (number > 0)
            {
                ArmyMembers.Add(new T());
                number--;
            }
        }
    }
}
