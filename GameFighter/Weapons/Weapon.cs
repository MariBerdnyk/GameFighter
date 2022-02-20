namespace GameFighter.Weapons
{
    public class Weapon
    {
        public int HealthParametr { get; init; } = default;

        public int AttackParametr { get; init; } = default;

        public int DefenceParametr { get; init; } = default;

        public int VampirismParametr { get; init; } = default;

        public int HealParametr { get; init; } = default;

        public int RangedAttackParametr { get; init; } = default;

        public Weapon(int healthParametr, int attackParametr, int defenceParametr, int vampirismParametr, int healParametr)
        {
            HealthParametr = healthParametr;
            AttackParametr = attackParametr;
            DefenceParametr = defenceParametr;
            VampirismParametr = vampirismParametr;
            HealParametr = healParametr;
        }

        public Weapon() { }
    }
}
