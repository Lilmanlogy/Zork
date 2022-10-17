namespace Zork
{
    internal class World
    {
        public Room[,] Rooms { get; }
        public World(Room[,] rooms)
        {
            Rooms = rooms;
        }
    }
}
