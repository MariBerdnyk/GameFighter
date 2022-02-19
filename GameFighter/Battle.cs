﻿using GameFighter.Models;
using System;
using System.Linq;

namespace GameFighter
{
    public static class Battle
    {
        public static bool Fight(Warrior warrior1, Warrior warrior2, Army army1 = null, Army army2 = null)
        {
            if (warrior1 == null || warrior2 == null)
            {
                throw new ArgumentNullException("warrior1 and warrior2 must be initialised!");
            }

            if (!warrior1.IsAlive || !warrior2.IsAlive)
            {
                throw new ArgumentException($"{warrior1} and {warrior2} must be alive!");
            }

            while (warrior1.IsAlive)
            {
                warrior1.Attacks(warrior2, army1);

                if (!warrior2.IsAlive)
                {
                    return true;
                }
                
                warrior2.Attacks(warrior1, army2);
            }
            
            return false;
        }

        public static bool Fight(Army army1, Army army2)
        {
            if (army1 == null || army2 == null)
            {
                throw new ArgumentNullException("army1 and army2 must be initialised!");
            }

            if (army1.CountUnits == 0 || army2.CountUnits == 0)
            {
                throw new ArgumentException($"{army1} and {army2} must have units!");
            }

            if (!army1.HasAliveUnit || !army2.HasAliveUnit)
            {
                throw new ArgumentException($"{army1} and {army2} must have alive units!");
            }

            if (army1.ArmyMembers[0].Attack <= 0 && army2.ArmyMembers[0].Attack <= 0)
            {
                throw new Exception("First units must be able to attack!");
            }

            army1.PrepareArmyForBattle();
            army2.PrepareArmyForBattle();

            for (int i = 0; i < army1.CountUnits; i++)
            {
                if (army1.ArmyMembers[i].IsAlive)
                {
                    for (int j = 0; j < army2.CountUnits; j++)
                    {
                        bool isUnitAlive = army2.ArmyMembers[j].IsAlive;
                        
                        if (isUnitAlive && !Fight(army1.ArmyMembers[i], army2.ArmyMembers[j], army1, army2))
                        {
                            army1.MoveUnits();
                            army2.MoveUnits();
                            i = -1;

                            break;
                        }

                        else if(isUnitAlive)
                        {
                            army1.MoveUnits();
                            army2.MoveUnits();
                            j = -1;
                        }
                    }
                }
            }

            //foreach (var item in army1.ArmyMembers)
            //{
            //    if (item.IsAlive)
            //    {
            //        foreach (var item2 in army2.ArmyMembers)
            //        {
            //            if (item2.IsAlive && !Fight(item, item2, army1, army2))
            //            {
            //                army1.MoveUnits();
            //                break;
            //            }
            //            else if (item2.IsAlive)
            //            {
            //                army2.MoveUnits();
            //            }
            //        }
            //    }
            //}
            return army1.HasAliveUnit;
        }

        public static bool StraightFight(Army army1, Army army2)
        {
            if (army1 == null || army2 == null)
            {
                throw new ArgumentNullException("army1 and army2 must be initialised!");
            }

            if (army1.CountUnits == 0 || army2.CountUnits == 0)
            {
                throw new ArgumentException($"{army1} and {army2} must have units!");
            }

            if (!army1.HasAliveUnit || !army2.HasAliveUnit)
            {
                throw new ArgumentException($"{army1} and {army2} must have alive units!");
            }

            if (army1.ArmyMembers[0].Attack <= 0 && army2.ArmyMembers[0].Attack <= 0)
            {
                throw new Exception("First units must be able to attack!");
            }

            army1.PrepareArmyForStraightBattle();
            army2.PrepareArmyForStraightBattle();

            do
            {
                foreach (var (first, second) in army1.ArmyMembers.Where(x => x.IsAlive).Zip(army2.ArmyMembers.Where(x => x.IsAlive)))
                {
                    Fight(first, second);
                }

            } while (army1.HasAliveUnit && army2.HasAliveUnit);

            return army1.HasAliveUnit;
        }
    }
}
