namespace Zork.Common
{
    class Enemy
    {
        public string Name { get; }
        public int Health { get; }
        public Enemy(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public override string ToString() => Name;
    }
}
