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

        [Fact]
        public void Fight_2Warrior2Lancer1Defender3WarlordVs2WarlordVampire5Healer2Knight_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(2);
            army1.AddUnits<Lancer>(2);
            army1.AddUnits<Defender>(1);
            army1.AddUnits<Warlord>(3);

            army2.AddUnits<Warlord>(2);
            army2.AddUnits<Vampire>(1);
            army2.AddUnits<Healer>(5);
            army2.AddUnits<Knight>(2);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_2Warrior3Lancer1Defender4WarlordVs1WarlordVampireRookieKnight_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(2);
            army1.AddUnits<Lancer>(3);
            army1.AddUnits<Defender>(1);
            army1.AddUnits<Warlord>(4);

            army2.AddUnits<Warlord>(1);
            army2.AddUnits<Vampire>(1);
            army2.AddUnits<Rookie>(1);
            army2.AddUnits<Knight>(1);

            army1.ArmyMembers[0].EquipWeapon(new Sword());
            army2.ArmyMembers[0].EquipWeapon(new Shield());

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void StraightFight_2Warrior3Lancer1Defender1WarlordVs5WarlordVampireRookieKnight_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(2);
            army1.AddUnits<Lancer>(3);
            army1.AddUnits<Defender>(1);
            army1.AddUnits<Warlord>(4);

            army2.AddUnits<Warlord>(1);
            army2.AddUnits<Vampire>(1);
            army2.AddUnits<Rookie>(1);
            army2.AddUnits<Knight>(1);

            army1.ArmyMembers[0].EquipWeapon(new Sword());
            army2.ArmyMembers[0].EquipWeapon(new Shield());

            Assert.False(Battle.StraightFight(army1, army2));
        }
    }
}
