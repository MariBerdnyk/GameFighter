using GameFighter;
using GameFighter.Models;
using System;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterDefenderTests
    {
        [Fact]
        public void Fight_TwoArmy5Warrior4DefenderVs4Warrior5Defender_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(5);
            army1.AddUnits<Defender>(4);
            army2.AddUnits<Warrior>(4);
            army2.AddUnits<Defender>(5);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy20Warrior5DefenderVs21Warrior4Defender_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(20);
            army1.AddUnits<Defender>(5);
            army2.AddUnits<Warrior>(21);
            army2.AddUnits<Defender>(4);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy10Warrior15DefenderVs5Warrior_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(10);
            army1.AddUnits<Defender>(5);
            army2.AddUnits<Warrior>(5);
            army1.AddUnits<Defender>(10);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy1Warrior3DefenderVs5Warrior_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Defender>(2);
            army1.AddUnits<Warrior>(1);
            army1.AddUnits<Defender>(1);
            army2.AddUnits<Warrior>(5);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_DefenderHealthAfterBattleVsRookie_Return50()
        {
            var rookie = new Rookie();
            var defender = new Defender();

            Battle.Fight(rookie, defender);

            Assert.Equal(60, defender.Health);
        }
    }
}
