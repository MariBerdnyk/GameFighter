using GameFighter;
using GameFighter.Models;
using GameFighter.Weapons;
using System;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterWarlordTests
    {
        [Fact]
        public void Fight_DefenderVsWarlord_ReturnFalse()
        {
            var defender = new Defender();
            var warlord = new Warlord();

            Assert.False(Battle.Fight(defender, warlord));
        }

        [Fact]
        public void Fight_WarlordVsVampire_ReturnTrue()
        {
            var warlord = new Warlord();
            var vampire = new Vampire();

            Assert.True(Battle.Fight(warlord, vampire));
        }

        [Fact]
        public void Fight_WarlordVsKnight_ReturnTrue()
        {
            var warlord = new Warlord();
            var knight = new Knight();

            Assert.True(Battle.Fight(warlord, knight));
        }

        [Fact]
        public void Fight_Warlord2Warrior2Lancer2HealerVsWarlordVampire2Healer2Knight_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warlord>(1);
            army1.AddUnits<Warrior>(2);
            army1.AddUnits<Lancer>(2);
            army1.AddUnits<Healer>(2);

            army2.AddUnits<Warlord>(1);
            army2.AddUnits<Vampire>(1);
            army2.AddUnits<Healer>(2);
            army2.AddUnits<Knight>(2);

            Assert.True(Battle.Fight(army1, army2));
        }
    }
}
