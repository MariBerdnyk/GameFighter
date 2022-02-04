using GameFighter;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterTests
    {
        [Fact]
        public void Fight_Two_Warriors()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Assert.True(Battle.Fight(warrior1, warrior2));
        }

        [Fact]
        public void Fight_Warrior_vs_Knight()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Assert.False(Battle.Fight(warrior, knight));
        }

        [Fact]
        public void Fight_Knight_vs_Warrior()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Assert.True(Battle.Fight(knight, warrior));
        }

        [Fact]
        public void Fight_Knight_vs_Knight()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Assert.True(Battle.Fight(knight1, knight2));
        }

        [Fact]
        public void Is_Warrior1_After_Battle_vs_Warrior_Alive()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.True(warrior1.IsAlive);
        }

        [Fact]
        public void Is_Warrior2_After_Battle_vs_Warrior_Alive()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.False(warrior2.IsAlive);
        }

        [Fact]
        public void Is_Warrior_After_Battle_vs_Knight_Alive()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior, knight);

            Assert.False(warrior.IsAlive);
        }

        [Fact]
        public void Is_Knight_After_Battle_vs_Warrior_Alive()
        {
            var warrior = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior, knight);

            Assert.True(knight.IsAlive);
        }

        [Fact]
        public void Is_Knight1_After_Battle_vs_Knight_Alive()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.True(knight1.IsAlive);
        }

        [Fact]
        public void Is_Knight2_After_Battle_vs_Knight_Alive()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.False(knight2.IsAlive);
        }

        [Fact]
        public void Warrior1_Health_After_Battle_vs_Warrior()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.Equal(5, warrior1.Health);
        }

        [Fact]
        public void Warrior2_Health_After_Battle_vs_Warrior()
        {
            var warrior1 = new Warrior();
            var warrior2 = new Warrior();

            Battle.Fight(warrior1, warrior2);

            Assert.Equal(0, warrior2.Health);
        }

        [Fact]
        public void Warrior_Health_After_Battle_vs_Knight()
        {
            var warrior1 = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior1, knight);

            Assert.Equal(-6, warrior1.Health);
        }

        [Fact]
        public void Knight_Health_After_Battle_vs_Warrior()
        {
            var warrior1 = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior1, knight);

            Assert.Equal(10, knight.Health);
        }

        [Fact]
        public void Knight_Health_After_Battle_vs_Knight()
        {
            var knight1 = new Knight();
            var knight2 = new Knight();

            Battle.Fight(knight1, knight2);

            Assert.Equal(1, knight1.Health);
        }
    }
}
