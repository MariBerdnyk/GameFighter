using GameFighter;
using System;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterTests
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
        public void Fight_KnightVsKnight_ReternTrue()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Assert.True(Battle.Fight(knight1, knight2));
        }

        [Fact]
        public void Fight_IsWarrior1AfterBattleVsWarriorAlive_ReternTrue()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.True(warrior1.IsAlive);
        }

        [Fact]
        public void Fight_IsWarrior2AfterBattleVsWarriorAlive_ReternFalse()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.False(warrior2.IsAlive);
        }

        [Fact]
        public void Fight_IsWarriorAfterBattleVsKnightAlive_ReternFalse()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior, knight);

            Assert.False(warrior.IsAlive);
        }

        [Fact]
        public void Fight_IsKnightAfterBattleVsWarriorAlive_ReternTrue()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior, knight);

            Assert.True(knight.IsAlive);
        }

        [Fact]
        public void Fight_IsKnight1AfterBattleVsKnightAlive_ReternTrue()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.True(knight1.IsAlive);
        }

        [Fact]
        public void Fight_IsKnight2AfterBattleVsKnightAlive_ReternFalse()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.False(knight2.IsAlive);
        }

        [Fact]
        public void Fight_Warrior1HealthAfterBattleVsWarrior_Retern5()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.Equal(5, warrior1.Health);
        }

        [Fact]
        public void Fight_Warrior2HealthAfterBattleVsWarrior_Retern0()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.Equal(0, warrior2.Health);
        }

        [Fact]
        public void Fight_WarriorHealthAfterBattleVsKnight_ReternNegative6()
        {
            var warrior1 = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior1, knight);

            Assert.Equal(-6, warrior1.Health);
        }

        [Fact]
        public void Fight_KnightHealthAfterBattleVsWarrior_Retern10()
        {
            var warrior1 = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior1, knight);

            Assert.Equal(10, knight.Health);
        }

        [Fact]
        public void Fight_KnightHealthAfterBattleVsKnight_Retern1()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.Equal(1, knight1.Health);
        }

        [Fact]
        public void Fight_NullWarriors_ThrowNotImplemetException()
        {
            Warrior warrior1 = null;
            Warrior warrior2 = null;

            Assert.Throws<NotImplementedException>(() => Battle.Fight(warrior1, warrior2));
        }
    }
}
