namespace ModMUD
{
    internal class Program
    {
        class Room
        {
            int Number { get; set; }
            string Name { get; set; }
            string Presentation { get; set; }
            int North { get; set; }
            int East { get; set; }
            int South { get; set; }
            int West { get; set; }

            public Room(int number = 0,
                string name = "Entrance",
                string presentation = "You've entered an empty room.",
                int north = -1,
                int east = -1,
                int south = -1,
                int west = -1)
            {
                Number = number;
                Name = name;
                Presentation = presentation;
                North = north;
                East = east;
                South = south;
                West = west;
            }
        }

        static void Main(string[] args)
        {
            string command;
            do
            {
                command = Console.ReadLine();
                if (command == "load")
                {
                    // NYI: load mockup or expansions
                    Console.WriteLine("NYI: load mockup or expansions");
                }
                else if (command == "start")
                {
                    // NYI: start the first room
                    Console.WriteLine("NYI: start the first room");
                }
                else if (command == "save")
                {
                    // NYI: save a room
                    Console.WriteLine("NYI: save a room");
                }
                else if (command == "n")
                {
                    // NYI: move north
                    Console.WriteLine("NYI: move north");
                }
                else if (command == "s")
                {
                    // NYI: move south
                    Console.WriteLine("NYI: move south");
                }
                else if (command == "e" || command == "ö")
                {
                    // NYI: move east
                    Console.WriteLine("NYI: move east");
                }
                else if (command == "w" || command == "v")
                {
                    // NYI: move west
                    Console.WriteLine("NYI: move west");
                }
            } while (command != "quit");
        }
    }
}