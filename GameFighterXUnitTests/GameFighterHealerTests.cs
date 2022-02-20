using GameFighter;
using GameFighter.Models;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterHealerTests
    {
        [Fact]
        public void Fight_TwoArmy7Lancer3Vampire1Healer4Warrior1Healer2DefenderVs4Warrior4Defender1Healer6Vampire4Lancer_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Lancer>(7);
            army1.AddUnits<Vampire>(3);
            army1.AddUnits<Healer>(1);
            army1.AddUnits<Warrior>(4);
            army1.AddUnits<Healer>(1);
            army1.AddUnits<Defender>(2);

            army2.AddUnits<Warrior>(4);
            army2.AddUnits<Defender>(4);
            army2.AddUnits<Healer>(1);
            army2.AddUnits<Vampire>(6);
            army2.AddUnits<Lancer>(4);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy1Lancer3Warrior1Healer4Warrior1Healer2KnightVs4Warrior4Defender1Healer6Vampire4Lancer_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Lancer>(1);
            army1.AddUnits<Warrior>(3);
            army1.AddUnits<Healer>(1);
            army1.AddUnits<Warrior>(4);
            army1.AddUnits<Healer>(1);
            army1.AddUnits<Knight>(2);

            army2.AddUnits<Warrior>(4);
            army2.AddUnits<Defender>(4);
            army2.AddUnits<Healer>(1);
            army2.AddUnits<Vampire>(6);
            army2.AddUnits<Lancer>(4);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy2KnightVs1Warrior1Healer_ReturnTrue()
        {
            Army army1 = new Army();
            Army army2 = new Army();
            army1.AddUnits<Knight>(2);
            army2.AddUnits<Warrior>(1);
            army2.AddUnits<Healer>(1);

            Assert.True(Battle.Fight(army1, army2));
        }
    }
}
