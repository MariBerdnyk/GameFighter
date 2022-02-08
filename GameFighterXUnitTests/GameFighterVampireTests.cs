using GameFighter;
using GameFighter.Models;
using System;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterVampireTests
    {
        [Fact]
        public void Fight_TwoArmy5Defender6Vampire7WarriorsVs6Warrior6Defender6Vampire_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Defender>(5);
            army1.AddUnits<Vampire>(6);
            army1.AddUnits<Warrior>(7);

            army2.AddUnits<Warrior>(6);
            army2.AddUnits<Defender>(6);
            army2.AddUnits<Vampire>(6);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy2Defender3Vampire4WarriorsVs4Warrior4Defender3Vampire_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Defender>(2);
            army1.AddUnits<Vampire>(3);
            army1.AddUnits<Warrior>(4);

            army2.AddUnits<Warrior>(4);
            army2.AddUnits<Defender>(4);
            army2.AddUnits<Vampire>(3);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy11Defender3Vampire4WarriorsVs4Warrior4Defender13Vampire_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Defender>(11);
            army1.AddUnits<Vampire>(3);
            army1.AddUnits<Warrior>(4);

            army2.AddUnits<Warrior>(4);
            army2.AddUnits<Defender>(4);
            army2.AddUnits<Vampire>(13);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoArmy9Defender3Vampire8WarriorsVs4Warrior4Defender13Vampire_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Defender>(9);
            army1.AddUnits<Vampire>(3);
            army1.AddUnits<Warrior>(8);

            army2.AddUnits<Warrior>(4);
            army2.AddUnits<Defender>(4);
            army2.AddUnits<Vampire>(13);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_TwoVampires_ReturnTrue()
        {
            var vampire1 = new Vampire();
            var vampire2 = new Vampire();
            
            Assert.True(Battle.Fight(vampire1, vampire2));
        }

        [Fact]
        public void Fight_DefenderVsVampire_ReturnTrue()
        {
            var defender = new Defender();
            var vampire = new Vampire();

            Assert.True(Battle.Fight(defender, vampire));
        }

        [Fact]
        public void Fight_WarriorVsVampire_ReturnTrue()
        {
            var warrior = new Warrior();
            var vampire = new Vampire();

            Assert.True(Battle.Fight(warrior, vampire));
        }

        [Fact]
        public void Fight_VampireVsWarrior_ReturnTrue()
        {
            var warrior = new Warrior();
            var vampire = new Vampire();

            Assert.True(Battle.Fight(vampire, warrior));
        }
    }
}
