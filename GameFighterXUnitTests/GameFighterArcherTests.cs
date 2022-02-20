using GameFighter;
using GameFighter.Models;
using GameFighter.Weapons;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterArcherTests
    {
        [Fact]
        public void Fight_WarriorArcherVs2Knights_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(1);
            army1.AddUnits<Archer>(1);
            army2.AddUnits<Knight>(2);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_WarriorArcherVsLancerKnight_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(1);
            army1.AddUnits<Archer>(1);
            army2.AddUnits<Lancer>(1);
            army2.AddUnits<Knight>(1);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_LancerArcherHealerWarlordVsLancerWarriorHealerWarlord_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Lancer>(1);
            army1.AddUnits<Archer>(1);
            army1.AddUnits<Healer>(1);
            army1.AddUnits<Warlord>(1);

            army2.AddUnits<Healer>(1);
            army2.AddUnits<Warrior>(1);
            army2.AddUnits<Warlord>(1);
            army2.AddUnits<Lancer>(1);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_LancerArcherHealerWarlordVsLancerHealerWarlord_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Lancer>(1);
            army1.AddUnits<Archer>(1);
            army1.AddUnits<Healer>(1);
            army1.AddUnits<Warlord>(1);

            army2.AddUnits<Healer>(1);
            army2.AddUnits<Warlord>(1);
            army2.AddUnits<Lancer>(1);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_WarriorArcherVs2Knight_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(1);
            army1.AddUnits<Archer>(1);

            army2.AddUnits<Knight>(2);

            Assert.True(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_WarriorArcherVs3Defender_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(1);
            army1.AddUnits<Archer>(1);

            army2.AddUnits<Defender>(3);

            Assert.False(Battle.Fight(army1, army2));
        }

        [Fact]
        public void Fight_WarriorArcherSwordVs4Defender_ReturnFalse()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Warrior>(1);
            army1.AddUnits<Archer>(1);
            army1.ArmyMembers[0].EquipWeapon(new Sword());

            army2.AddUnits<Defender>(4);

            Assert.True(Battle.Fight(army1, army2));
        }
    }
}
