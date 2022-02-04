using GameFighter;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterTests
    {
        [Fact]
        public void Fight_Two_Warriors()
        {
            var warrior_1 = new Warrior();
            var warrior_2 = new Warrior();

            Assert.True(Battle.Fight(warrior_1, warrior_2));
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
            var knight_1 = new Knight();
            var knight_2 = new Knight();

            Assert.True(Battle.Fight(knight_1, knight_2));
        }

        [Fact]
        public void Is_Warrior1_After_Battle_vs_Warrior_Alive()
        {
            var warrior_1 = new Warrior();
            var warrior_2 = new Warrior();

            Battle.Fight(warrior_1, warrior_2);

            Assert.True(warrior_1.IsAlive);
        }

        [Fact]
        public void Is_Warrior2_After_Battle_vs_Warrior_Alive()
        {
            var warrior_1 = new Warrior();
            var warrior_2 = new Warrior();

            Battle.Fight(warrior_1, warrior_2);

            Assert.False(warrior_2.IsAlive);
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
            var knight_1 = new Knight();
            var knight_2 = new Knight();

            Battle.Fight(knight_1, knight_2);

            Assert.True(knight_1.IsAlive);
        }

        [Fact]
        public void Is_Knight2_After_Battle_vs_Knight_Alive()
        {
            var knight_1 = new Knight();
            var knight_2 = new Knight();

            Battle.Fight(knight_1, knight_2);

            Assert.False(knight_2.IsAlive);
        }

        [Fact]
        public void Warrior1_Health_After_Battle_vs_Warrior()
        {
            var warrior_1 = new Warrior();
            var warrior_2 = new Warrior();

            Battle.Fight(warrior_1, warrior_2);

            Assert.Equal(5, warrior_1.Health);
        }

        [Fact]
        public void Warrior2_Health_After_Battle_vs_Warrior()
        {
            var warrior_1 = new Warrior();
            var warrior_2 = new Warrior();

            Battle.Fight(warrior_1, warrior_2);

            Assert.Equal(0, warrior_2.Health);
        }

        [Fact]
        public void Warrior_Health_After_Battle_vs_Knight()
        {
            var warrior_1 = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior_1, knight);

            Assert.Equal(-6, warrior_1.Health);
        }

        [Fact]
        public void Knight_Health_After_Battle_vs_Warrior()
        {
            var warrior_1 = new Warrior();
            var knight = new Knight();

            Battle.Fight(warrior_1, knight);

            Assert.Equal(10, knight.Health);
        }

        [Fact]
        public void Knight_Health_After_Battle_vs_Knight()
        {
            var knight_1 = new Knight();
            var knight_2 = new Knight();

            Battle.Fight(knight_1, knight_2);

            Assert.Equal(1, knight_1.Health);
        }
    }
}
