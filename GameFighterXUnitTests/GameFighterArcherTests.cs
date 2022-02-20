using GameFighter;
using GameFighter.Models;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterArcherTests
    {
        [Fact]
        public void Fight_LancerAngelVs2Knights_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Lancer>(1);
            army1.AddUnits<Angel>(1);

            army2.AddUnits<Knight>(2);

            Assert.False(Battle.Fight(army1, army2));
        }
    }
}
