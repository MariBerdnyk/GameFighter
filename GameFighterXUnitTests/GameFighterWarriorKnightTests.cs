using GameFighter;
using GameFighter.Models;
using System;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterWarriorKnightTests
    {
        [Fact]
        public void Fight_TwoWarriors_ReturnTrue()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Assert.True(Battle.Fight(warrior1, warrior2));
        }

        [Fact]
        public void Fight_WarriorVsKnight_ReturnFalse()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Assert.False(Battle.Fight(warrior, knight));
        }

        [Fact]
        public void Fight_KnightVsWarrior_ReturnTrue()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Assert.True(Battle.Fight(knight, warrior));
        }

        [Fact]
        public void Fight_KnightVsKnight_ReturnTrue()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Assert.True(Battle.Fight(knight1, knight2));
        }

        [Fact]
        public void Fight_WarriorVsWarrior_FirstWarriorIsAlive()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.True(warrior1.IsAlive);
        }

        [Fact]
        public void Fight_WarriorVsWarrior_SecondWarriorIsAlive()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.False(warrior2.IsAlive);
        }

        [Fact]
        public void Fight_WarriorVsKnight_WarriorIsAlive()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior, knight);

            Assert.False(warrior.IsAlive);
        }

        [Fact]
        public void Fight_WarriorVsKnight_KnightIsAlive()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior, knight);

            Assert.True(knight.IsAlive);
        }

        [Fact]
        public void Fight_KnightVsKnight_FirstKnightIsAlive()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.True(knight1.IsAlive);
        }

        [Fact]
        public void Fight_KnightVsKnight_SecondKnightIsAlive()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.False(knight2.IsAlive);
        }

        [Fact]
        public void Fight_Warrior1HealthAfterBattleVsWarrior_Return5()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.Equal(5, warrior1.Health);
        }

        [Fact]
        public void Fight_Warrior2HealthAfterBattleVsWarrior_Return0()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.Equal(0, warrior2.Health);
        }

        [Fact]
        public void Fight_WarriorHealthAfterBattleVsKnight_ReturnNegative6()
        {
            var warrior1 = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior1, knight);

            Assert.Equal(-6, warrior1.Health);
        }

        [Fact]
        public void Fight_KnightHealthAfterBattleVsWarrior_Return10()
        {
            var warrior1 = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior1, knight);

            Assert.Equal(10, knight.Health);
        }

        [Fact]
        public void Fight_KnightHealthAfterBattleVsKnight_Return1()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.Equal(1, knight1.Health);
        }

        [Fact]
        public void Fight_NullWarriors_ThrowArgumentNullException()
        {
            Warrior warrior1 = null;
            Warrior warrior2 = null;

            Assert.Throws<ArgumentNullException>(() => Battle.Fight(warrior1, warrior2));
        }
    }
}
