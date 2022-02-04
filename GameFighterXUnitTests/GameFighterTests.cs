using GameFighter;
using System;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterTests
    {
        [Fact]
        public void FightTwoWarriors()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Assert.True(Battle.Fight(warrior1, warrior2));
        }

        [Fact]
        public void FightWarriorVsKnight()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Assert.False(Battle.Fight(warrior, knight));
        }

        [Fact]
        public void FightKnightVsWarrior()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Assert.True(Battle.Fight(knight, warrior));
        }

        [Fact]
        public void FightKnightVsKnight()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Assert.True(Battle.Fight(knight1, knight2));
        }

        [Fact]
        public void IsWarrior1AfterBattleVsWarriorAlive()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.True(warrior1.IsAlive);
        }

        [Fact]
        public void IsWarrior2AfterBattleVsWarriorAlive()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.False(warrior2.IsAlive);
        }

        [Fact]
        public void IsWarriorAfterBattleVsKnightAlive()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior, knight);

            Assert.False(warrior.IsAlive);
        }

        [Fact]
        public void IsKnightAfterBattleVsWarriorAlive()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior, knight);

            Assert.True(knight.IsAlive);
        }

        [Fact]
        public void IsKnight1AfterBattleVsKnightAlive()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.True(knight1.IsAlive);
        }

        [Fact]
        public void IsKnight2AfterBattleVsKnightAlive()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.False(knight2.IsAlive);
        }

        [Fact]
        public void Warrior1HealthAfterBattleVsWarrior()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.Equal(5, warrior1.Health);
        }

        [Fact]
        public void Warrior2HealthAfterBattleVsWarrior()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.Equal(0, warrior2.Health);
        }

        [Fact]
        public void WarriorHealthAfterBattleVsKnight()
        {
            var warrior1 = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior1, knight);

            Assert.Equal(-6, warrior1.Health);
        }

        [Fact]
        public void KnightHealthAfterBattleVsWarrior()
        {
            var warrior1 = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior1, knight);

            Assert.Equal(10, knight.Health);
        }

        [Fact]
        public void KnightHealthAfterBattleVsKnight()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.Equal(1, knight1.Health);
        }

        [Fact]
        public void NullWarriors()
        {
            Warrior warrior1 = null;
            Warrior warrior2 = null;

            Assert.Throws<NotImplementedException>(() => Battle.Fight(warrior1, warrior2));
        }
    }
}
