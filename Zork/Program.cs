using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine().Trim().ToUpper();
            Commands command = ToCommand(inputString); //Refactoring
            
            if (command == Commands.QUIT)
            {
                Console.WriteLine("Thank you for playing.");
            }
            else if (command == Commands.LOOK)
            {
                Console.WriteLine("This is an open field west of a white house, with a boarded front door. \nA rubber mat saying 'Welcome to Zork!' lies by the door");
            }
            else
            {
                Console.WriteLine("Unrecognized command");
            }
        }

        private static Commands ToCommand(string commandString)
        {
            if (Enum.TryParse<Commands>(commandString, true, out Commands command))
            {
                return command;
            }
            else
            {
                return Commands.UNKNOWN;
            }
        }
    }
}
