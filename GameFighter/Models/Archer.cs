namespace GameFighter.Models
{
    public class Archer : Warrior
    {
        public int RangedAttack { get; protected set; }

        public Archer()
        {
            Attack = 2;
            RangedAttack = 5;

            ChangedAttack = Attack;
            DefaultAttack = ChangedAttack;
        }

        public override void UniqueOption(Warrior warrior)
        {
            if (IsAlive && warrior.Attack == warrior.ChangedAttack)
            {
                warrior.Attack += RangedAttack;
            }
        }

        public override void PrepareForBattle(Warrior warrior)
        {
            foreach (var item in warrior.unitsWeapons)
            {
                EquipWeapon(item);
            }
        }
    }
}
