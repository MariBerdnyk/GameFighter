using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFighter.Weapons
{
    public class GreatAxe : Weapon
    {
        public GreatAxe()
        {
            HealthParametr = -15;
            AttackParametr = 5;
            DefenceParametr = -2;
            VampirismParametr = 10;
        }
    }
}
