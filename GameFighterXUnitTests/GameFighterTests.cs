using GameFighter;
using System;
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

            Battle.Fight(warrior_1, warrior_2);

            Assert.True(Battle.Fight(warrior_1, warrior_2));
        }
    }
}
