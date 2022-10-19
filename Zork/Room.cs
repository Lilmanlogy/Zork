using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Zork
{
    internal class Room
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        public Dictionary<Directions, Room> Neighbors { get; private set; }
        [JsonIgnore]
        private string[] InventoryNames { get; set; } 
        
        public Room(string name, string description, Dictionary<Directions, string> neighborNames, string[] inventoryNames)
        {
            Name = name;
            Description = description;
            InventoryNames = inventoryNames ?? new string[0];
            
        }
        public void UpdateInventory(World world)
        {
            Inventory.Add(world.ItemsByName[InventoryNames]);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
