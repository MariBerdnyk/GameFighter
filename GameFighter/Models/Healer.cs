namespace GameFighter.Models
{
    public class Healer : Warrior
    {
        public int Heal { get; protected set; }
        public Healer()
        {
            Attack = 0;
            Health = 60;
            Heal = 2;
        }
    }
}
