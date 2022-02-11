using System.Collections.Generic;
using System.Linq;

namespace GameFighter.Models
{
    public class Army
    {
        public readonly List<Warrior> ArmyMembers = new List<Warrior>();

        public int CountUnits => ArmyMembers.Count;

        public Warrior Next(Warrior warriorBefore)
        {
            return ArmyMembers.SkipWhile(x => x != warriorBefore).Skip(1).Where(x => x.IsAlive).FirstOrDefault();
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
