using GameFighter;
using GameFighter.Models;
using GameFighter.Weapons;
using System;
using Xunit;

namespace GameFighterXUnitTests
{
    public class GameFighterWeaponTests
    {
        [Fact]
        public void Fight_WarriorWeaponVsVampireSword_ReturnTrue()
        {
            var warrior = new Warrior();
            var vampire = new Vampire();

            warrior.EquipWeapon(new Weapon(-10, 5, 0, 40, 0));
            vampire.EquipWeapon(new Sword());

            Assert.True(Battle.Fight(warrior, vampire));
        }

        [Fact]
        public void Fight_DefenderShieldVsLancerGreatAxe_ReturnFalse()
        {
            var defender = new Defender();
            var lancer = new Lancer();

            defender.EquipWeapon(new Shield());
            lancer.EquipWeapon(new GreatAxe());

            Assert.False(Battle.Fight(defender, lancer));
        }

        [Fact]
        public void Fight_HealerMagicWandVsKnightKatana_ReturnFalse()
        {
            var healer = new Healer();
            var knight = new Knight();

            healer.EquipWeapon(new MagicWand());
            knight.EquipWeapon(new Katana());

            Assert.False(Battle.Fight(healer, knight));
        }

        [Fact]
        public void Fight_DefenderShieldMagicWandVsVampireShieldKatana_ReturnFalse()
        {
            var defender = new Defender();
            var vampire = new Vampire();

            defender.EquipWeapon(new Shield());
            defender.EquipWeapon(new MagicWand());
            vampire.EquipWeapon(new Shield());
            vampire.EquipWeapon(new Katana());

            Assert.False(Battle.Fight(defender, vampire));
        }

        [Fact]
        public void Fight_KnightMagicWandLancerGreatAxeVsVampireMagicWandHealerGreatAxe_ReturnTrue()
        {
            var army1 = new Army();
            var army2 = new Army();

            army1.AddUnits<Knight>(1);
            army1.AddUnits<Lancer>(1);

            army2.AddUnits<Vampire>(1);
            army2.AddUnits<Healer>(1);

            army1.ArmyMembers[0].EquipWeapon(new MagicWand());
            army1.ArmyMembers[1].EquipWeapon(new GreatAxe());

            army2.ArmyMembers[0].EquipWeapon(new MagicWand());
            army2.ArmyMembers[1].EquipWeapon(new GreatAxe());

            Assert.True(Battle.Fight(army1, army2));
        }


    }
}
