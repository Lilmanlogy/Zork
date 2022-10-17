using System;

namespace Zork
{
    internal class Player
    {
        public Room CurrentRoom
        {
            get
            {
                return _world.Rooms[_location.Row, _location.Column];
            }
        }
        public Player(World world, string startingLocation)
        {
            _world = world;
            for (int row = 0; row < _world.Rooms.GetLength(0); row++)
            {
                for (int column = 0; column < _world.Rooms.GetLength(1); column++)
                {
                    Room room = _world.Rooms[row, column];
                    if (string.Compare(room.Name,startingLocation, ignoreCase: true) == 0)
                    {
                        _location = (row, column);
                        return;
                    }
                }
            }
            throw new Exception($"Invalid starting location: {startingLocation}");
        }
        public bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH when _location.Row < _world.Rooms.GetLength(0) - 1:
                    _location.Row++;
                    didMove = true;
                    break;

                case Commands.SOUTH when _location.Row > 0:
                    _location.Row--;
                    didMove = true;
                    break;

                case Commands.EAST when _location.Column < _world.Rooms.GetLength(1) - 1:
                    _location.Column++;
                    didMove = true;
                    break;
                case Commands.WEST when _location.Column > 0:
                    _location.Column--;
                    didMove = true;
                    break;
            }
            return didMove;
        }
        private World _world;
        private (int Row, int Column) _location;

    }
}
