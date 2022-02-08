using GameFighter;
using GameFighter.Models;
using System;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterVampireTests
    {
        [Fact]
        public void Fight_TwoArmy5Defender6Vampire7WarriorsVs6Warrior6Defender6Vampire_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Defender>(5);
            army1.AddUnits<Vampire>(6);
            army1.AddUnits<Warrior>(7);

            army2.AddUnits<Warrior>(6);
            army2.AddUnits<Defender>(6);
            army2.AddUnits<Vampire>(6);

            Assert.False(Battle.Fight(army1, army2));
        }
    }
}
