using System;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using Newtonsoft.Json;

namespace Zork
{
    internal class Program
    {
        static void Main()
        {
            const string defaulRoomsFilename = @"Content\Game.json";
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(@"Content\Game.json"));


            Console.WriteLine("Welcome to Zork!");

            
        }

        private enum CommandLineArguments
        {
            RoomsFileName = 0
        }
        private static (int Row, int Column) _location = (1, 1);
    }
}
