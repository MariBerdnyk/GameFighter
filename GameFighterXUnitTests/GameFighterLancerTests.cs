using GameFighter;
using GameFighter.Models;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterLancerTests
    {
        [Fact]
        public void Fight_TwoArmy1LancerVs1Warrior1Knight_ReturnHelthKnight13()
        {
            Army army1 = new Army();
            Army army2 = new Army();

            army1.AddUnits<Lancer>(1);
            army2.AddUnits<Warrior>(1);
            army2.AddUnits<Knight>(1);

            Battle.Fight(army1, army2);
            Assert.Equal(13, army2.ArmyMembers[1].Health);
        }

        [Fact]
        public void Fight_TwoArmy5Lancer3Vampire4Warriors2DefenderVs4Warrior4Defender6Vampire5Lancer_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Lancer>(5);
            army1.AddUnits<Vampire>(3);
            army1.AddUnits<Warrior>(4);
            army1.AddUnits<Defender>(2);

            army2.AddUnits<Warrior>(4);
            army2.AddUnits<Defender>(4);
            army2.AddUnits<Vampire>(6);
            army2.AddUnits<Lancer>(5);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy7Lancer3Vampire4Warriors2DefenderVs4Warrior4Defender6Vampire4Lancer_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Lancer>(7);
            army1.AddUnits<Vampire>(3);
            army1.AddUnits<Warrior>(4);
            army1.AddUnits<Defender>(2);

            army2.AddUnits<Warrior>(4);
            army2.AddUnits<Defender>(4);
            army2.AddUnits<Vampire>(6);
            army2.AddUnits<Lancer>(4);

            Assert.True(Battle.Fight(army1, army2));
        }
    }
}