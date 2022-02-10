using System.Collections.Generic;

namespace GameFighter.Models
{
    public class Army
    {
        public readonly List<Warrior> ArmyMembers = new List<Warrior>();

        public int CountUnits => ArmyMembers.Count;

        public Warrior Next(Warrior item)
        {
            int index = ArmyMembers.IndexOf(item) + 1;
            return index >= CountUnits ? null : ArmyMembers[index];
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
            while (number > 0)
            {
                ArmyMembers.Add(new T());
                number--;
            }
        }
    }
}
