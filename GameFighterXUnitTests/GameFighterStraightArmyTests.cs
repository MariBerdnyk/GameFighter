using GameFighter;
using GameFighter.Models;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterStraightArmyTests
    {
        [Fact]
        public void StraightFight_5Lancer3Vampire4Warrior4DefenderVs4Warrior4Defender6Vampire5Lancer_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Lancer>(5);
            army1.AddUnits<Vampire>(3);
            army1.AddUnits<Warrior>(4);
            army1.AddUnits<Defender>(4);

            army2.AddUnits<Warrior>(4);
            army2.AddUnits<Defender>(4);
            army2.AddUnits<Vampire>(6);
            army2.AddUnits<Lancer>(5);

            Assert.False(Battle.StraightFight(army1, army2));
        }

        [Fact]
        public void StraightFight_7Lancer3Vampire4Warrior2DefenderVs4Warrior4Defender6Vampire4Lancer_ReturnTrue()
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

            Assert.True(Battle.StraightFight(army1, army2));
        }

        [Fact]
        public void StraightFight_7Lancer3Vampire1Healer4Warrior1Healer2DefenderVs4Warrior4Defender1Healer6Vampire4Lancer_ReturnFalse()
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

            Assert.False(Battle.StraightFight(army1, army2));
        }

        [Fact]
        public void StraightFight_4Lancer3Warrior1Healer4Warrior1Healer2KnightVs4Warrior4Defender1Healer2Vampire4Lancer_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Lancer>(4);
            army1.AddUnits<Warrior>(3);
            army1.AddUnits<Healer>(1);
            army1.AddUnits<Warrior>(4);
            army1.AddUnits<Healer>(1);
            army1.AddUnits<Knight>(2);

            army2.AddUnits<Warrior>(4);
            army2.AddUnits<Defender>(4);
            army2.AddUnits<Healer>(1);
            army2.AddUnits<Vampire>(2);
            army2.AddUnits<Lancer>(4);

            Assert.True(Battle.StraightFight(army1, army2));
        }
    }
}

