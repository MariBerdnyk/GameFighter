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
    }
}
