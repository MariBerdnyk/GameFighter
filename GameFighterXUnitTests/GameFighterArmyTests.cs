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

        [Fact]
        public void Fight_TwoArmy3Warriors_ReturnTrue()
        {
            var warrior = new Warrior();
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits(warrior, 3);
            army2.AddUnits(warrior, 3);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy1WarriorVs2Warriors_ReturnFalse()
        {
            var warrior = new Warrior();
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits(warrior, 1);
            army2.AddUnits(warrior, 2);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy2WarriorVs3Warriors_ReturnFalse()
        {
            var warrior = new Warrior();
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits(warrior, 2);
            army2.AddUnits(warrior, 3);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy5WarriorVs7Warriors_ReturnFalse()
        {
            var warrior = new Warrior();
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits(warrior, 5);
            army2.AddUnits(warrior, 7);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy20WarriorVs21Warriors_ReturnTrue()
        {
            var warrior = new Warrior();
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits(warrior, 20);
            army2.AddUnits(warrior, 21);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy10WarriorVs11Warriors_ReturnTrue()
        {
            var warrior = new Warrior();
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits(warrior, 10);
            army2.AddUnits(warrior, 11);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy4Warrior1KnightVs6Warriors_ReturnFalse()
        {
            var warrior = new Warrior();
            var knight = new Knight();
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits(warrior, 4);
            army1.AddUnits(knight, 1);
            army2.AddUnits(warrior, 6);

            Assert.False(Battle.Fight(army1, army2));
        }
    }
}
