﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFighter.Models
{
    public class Army
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
        
    }
}
