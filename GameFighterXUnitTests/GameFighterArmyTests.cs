using GameFighter;
using GameFighter.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterArmyTests
    {
        public static IEnumerable<object[]> TestsInfoForTwo =>
        new List<object[]>
        {
            new object[] { 3, 3, true },
            new object[] { 3, 3, true },
            new object[] { 1, 2, false },
            new object[] { 2, 3, false },
            new object[] { 5, 7, false },
            new object[] { 20, 21, true },
            new object[] { 10, 11, true },
        };

        public static IEnumerable<object[]> TestsInfoForThree =>
        new List<object[]>
        {
            new object[] { 4, 1, 6, false },
        };

        [Theory]
        [MemberData(nameof(TestsInfoForTwo))]
        public void Fight_TwoArmy3Knights_ReturnTrue(int unitCount1, int unitCount2, bool expectedResult)
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Knight>(unitCount1);
            army2.AddUnits<Knight>(unitCount2);

            Assert.Equal(expectedResult, Battle.Fight(army1, army2));
        }

        [Theory]
        [MemberData(nameof(TestsInfoForTwo))]
        public void Fight_TwoArmy3Warriors_ReturnTrue(int unitCount1, int unitCount2, bool expectedResult)
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(unitCount1);
            army2.AddUnits<Warrior>(unitCount2);

            Assert.Equal(expectedResult, Battle.Fight(army1, army2));
        }

        [Theory]
        [MemberData(nameof(TestsInfoForTwo))]
        public void Fight_TwoArmy1WarriorVs2Warriors_ReturnFalse(int unitCount1, int unitCount2, bool expectedResult)
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(unitCount1);
            army2.AddUnits<Warrior>(unitCount2);

            Assert.Equal(expectedResult, Battle.Fight(army1, army2));
        }

        [Theory]
        [MemberData(nameof(TestsInfoForTwo))]
        public void Fight_TwoArmy2WarriorVs3Warriors_ReturnFalse(int unitCount1, int unitCount2, bool expectedResult)
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(unitCount1);
            army2.AddUnits<Warrior>(unitCount2);

            Assert.Equal(expectedResult, Battle.Fight(army1, army2));
        }

        [Theory]
        [MemberData(nameof(TestsInfoForTwo))]
        public void Fight_TwoArmy5WarriorVs7Warriors_ReturnFalse(int unitCount1, int unitCount2, bool expectedResult)
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(unitCount1);
            army2.AddUnits<Warrior>(unitCount2);

            Assert.Equal(expectedResult, Battle.Fight(army1, army2));
        }

        [Theory]
        [MemberData(nameof(TestsInfoForTwo))]
        public void Fight_TwoArmy20WarriorVs21Warriors_ReturnTrue(int unitCount1, int unitCount2, bool expectedResult)
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(unitCount1);
            army2.AddUnits<Warrior>(unitCount2);

            Assert.Equal(expectedResult, Battle.Fight(army1, army2));
        }

        [Theory]
        [MemberData(nameof(TestsInfoForTwo))]
        public void Fight_TwoArmy10WarriorVs11Warriors_ReturnTrue(int unitCount1, int unitCount2, bool expectedResult)
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(unitCount1);
            army2.AddUnits<Warrior>(unitCount2);

            Assert.Equal(expectedResult, Battle.Fight(army1, army2));
        }

        [Theory]
        [MemberData(nameof(TestsInfoForThree))]
        public void Fight_TwoArmy4Warrior1KnightVs6Warriors_ReturnFalse(int unitCount1, int unitCount2, int unitCount3, bool expectedResult)
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(unitCount1);
            army1.AddUnits<Knight>(unitCount2);
            army2.AddUnits<Warrior>(unitCount3);

            Assert.Equal(expectedResult, Battle.Fight(army1, army2));
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
