using System.Collections.Generic;
using System.Linq;

namespace GameFighter.Models
{
    public class Warlord : Defender
    {
        public Warlord()
        {
            Health = 100;
            Attack = 4;

            MaxHealth = Health;
            DefaultAttack = Attack;
        }

        public List<Warrior> MoveUnits(List<Warrior> army)
        {
            List<Warrior> newArmy = new();

            List<Warrior> warlords = new();
            List<Warrior> lancers = new();
            List<Warrior> healers = new();
            List<Warrior> deadUnits = new();
            List<Warrior> others = new();
            List<Warrior> angels = new();


            foreach (var item in army)
            {
                if (!item.IsAlive)
                {
                    deadUnits.Add(item);
                }
                else if(item is Lancer)
                {
                    lancers.Add(item);
                }
                else if (item is Healer)
                {
                    healers.Add(item);
                }
                else if (item is Warlord)
                {
                    warlords.Add(item);
                }
                else if(item is Angel)
                {
                    angels.Add(item);
                }
                else
                {
                    others.Add(item);
                }
            }

            if(lancers.Count > 0 && angels.Count > 0)
            {
                var tempCol = lancers.Zip(angels).ToList();
                foreach (var (first, second) in tempCol)
                {
                    newArmy.Add(first);
                    newArmy.Add(second);

                    lancers.Remove(first);
                    angels.Remove(second);
                }
            }

            if(others.Count > 0 && angels.Count > 0)
            {
                var tempCol = lancers.Zip(angels).ToList();
                foreach (var (first, second) in tempCol)
                {
                    newArmy.Add(first);
                    newArmy.Add(second);

                    others.Remove(first);
                    angels.Remove(second);
                }
            }

            if(lancers.Count > 0)
            {
                newArmy.Add(lancers.First());
                lancers.RemoveAt(0);
            }
            else if (others.Count > 0)
            {
                newArmy.Add(others.First());
                others.RemoveAt(0);
            }
            newArmy.AddRange(healers);
            newArmy.AddRange(lancers);
            newArmy.AddRange(others);
            newArmy.AddRange(angels);
            newArmy.AddRange(warlords);
            newArmy.AddRange(deadUnits);

            return newArmy;
        }
    }
}
