using Newtonsoft.Json;
using System.Collections.Generic;

namespace Zork
{
    internal class World
    {
        public Room[,] Rooms { get; }
        public Item[] Items { get; }
        
        [JsonIgnore]
        public Dictionary<string>

        public World(Room[,] rooms, Item[] items)
        {
            Rooms = rooms;
            Items = items;
        }
    }
}
