using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFighter.Models
{
    public class Army : IEnumerable
    {
        public List<Warrior> ArmyMembers { get; protected set; }

        public int CountUnits => ArmyMembers.Count;

        public int CountAliveUnits
        {
            get
            {
                int alive = 0;
                foreach (var item in ArmyMembers)
                {
                    if (item.IsAlive)
                    {
                        alive++;
                    }
                }
                return alive;
            }
        }

        public Army()
        {
            ArmyMembers = new List<Warrior>();
        }

        public void AddUnits(Warrior warrior, int number)
        {
            while (number > 0)
            {
                warrior = new Warrior();
                ArmyMembers.Add(warrior);
                number--;
            }
        }

        public void AddUnits(Knight knight, int number)
        {
            while (number > 0)
            {
                knight = new Knight();
                ArmyMembers.Add(knight);
                number--;
            }
        }

        public IEnumerator GetEnumerator() => ArmyMembers.GetEnumerator();
    }
}
