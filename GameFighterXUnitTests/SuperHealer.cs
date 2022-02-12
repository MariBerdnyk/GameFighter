using GameFighter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFighterXUnitTests
{
    internal class SuperHealer : Healer
    {
        public SuperHealer()
        {
            Heal = 5;
        }
    }
}
