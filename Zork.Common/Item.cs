namespace Zork.Common
{
    public class Item
    {
        public string Name { get; }

        public string LookDescription { get; }

        public string InventoryDescription { get; }
        public string Type { get; }
        public int Health { get; set; }

        public Item(string name, string lookDescription, string inventoryDescription, string type, int health)
        {
            Name = name;
            LookDescription = lookDescription;
            InventoryDescription = inventoryDescription;
            Type = type;
            Health = health;
        }

        public override string ToString() => Name;
    }
}