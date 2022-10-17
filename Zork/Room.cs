using System.Collections.Generic;

namespace Zork
{
    internal class Room
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        public Dictionary<Directions, Room> Neighbors { get; private set; }

        public Room(string name, string description, Dictionary<Directions, string> neighborNames)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
