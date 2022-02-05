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
                ArmyMembers.Add(warrior);
                warrior = new Warrior();
                number--;
            }
        }

        public void AddUnits(Knight knight, int number)
        {
            while (number > 0)
            {
                ArmyMembers.Add(knight);
                knight = new Knight();
                number--;
            }
        }

        public IEnumerator GetEnumerator() => ArmyMembers.GetEnumerator();
    }
}
