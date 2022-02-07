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
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Knight>(3);
            army2.AddUnits<Knight>(3);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy3Warriors_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(3);
            army2.AddUnits<Warrior>(3);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy1WarriorVs2Warriors_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(1);
            army2.AddUnits<Warrior>(2);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy2WarriorVs3Warriors_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(2);
            army2.AddUnits<Warrior>(3);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy5WarriorVs7Warriors_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(5);
            army2.AddUnits<Warrior>(7);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy20WarriorVs21Warriors_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(20);
            army2.AddUnits<Warrior>(21);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy10WarriorVs11Warriors_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(10);
            army2.AddUnits<Warrior>(11);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy4Warrior1KnightVs6Warriors_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(4);
            army1.AddUnits<Knight>(1);
            army2.AddUnits<Warrior>(6);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_NullArmies_ThrowArgumentNullException()
        {
            Army army1 = null;
            Army army2 = null;

            Assert.Throws<ArgumentNullException>(() => Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_ArmiesWithNoUnits_ThrowArgumentException()
        {
            Army army1 = new Army();
            Army army2 = new Army();

            Assert.Throws<ArgumentException>(() => Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_DeadArmies_ThrowArgumentException()
        {
            Army army1 = new Army();
            Army army2 = new Army();
            army1.AddUnits<Warrior>(1);
            army2.AddUnits<Warrior>(2);

            Battle.Fight(army1, army2);

            Assert.Throws<ArgumentException>(() => Battle.Fight(army1, army2));
        }
    }
}
