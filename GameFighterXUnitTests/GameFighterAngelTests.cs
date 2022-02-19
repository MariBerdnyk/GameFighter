using GameFighter;
using GameFighter.Models;
using System;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterAngelTests
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

        [Fact]
        public void Fight_LancerAngelVsKnightWarrior_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Lancer>(1);
            army1.AddUnits<Angel>(1);

            army2.AddUnits<Knight>(1);
            army2.AddUnits<Warrior>(1);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_AngelVsWarrior_ReturnFalse()
        {
            var angel = new Angel();
            var warrior = new Warrior();

            Assert.False(Battle.Fight(angel, warrior));
        }

        [Fact]
        public void Fight_AngelLancerHealerWarlordVs4WarriorWarlord_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Angel>(1);
            army1.AddUnits<Lancer>(1);
            army1.AddUnits<Healer>(1);
            army1.AddUnits<Warlord>(1);

            army2.AddUnits<Warrior>(3);
            army2.AddUnits<Warlord>(1);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_AngelLancerHealerWarlordVs7WarriorWarlord_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Angel>(1);
            army1.AddUnits<Lancer>(1);
            army1.AddUnits<Healer>(1);
            army1.AddUnits<Warlord>(1);

            army2.AddUnits<Warrior>(4);
            army2.AddUnits<Warlord>(1);

            Assert.False(Battle.Fight(army1, army2));
        }
    }
}
