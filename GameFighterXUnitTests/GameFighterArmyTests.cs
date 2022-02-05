using GameFighter;
using GameFighter.Models;
using System;
using Xunit;


namespace GameFighterXUnitTests
{
    public class GameFighterArmyTests
    {
        [Fact]
        public void Fight_TwoArmy3Knights_ReturnTrue()
        {
            var knight = new Knight();

            var army1 = new Army();
            var army2 = new Army();
            army1.AddUnits(knight, 3);
            army2.AddUnits(knight, 3);

            Assert.True(Battle.Fight(army1, army2));
        }
    }
}
