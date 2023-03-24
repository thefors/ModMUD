using System.Threading.Channels;

namespace ModMUD
{
    internal class Program
    {
        class Room
        {
            int Number { get; set; }
            string Name { get; set; }
            string Presentation { get; set; }
            public int North { get; set; }
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

     
            public void Print()
            {
                Console.WriteLine($"{Name}\n");
                Console.WriteLine(Presentation);
                Console.WriteLine("\nAlternativ");

                if (North > -1)
                    Console.WriteLine("\tn - norrut");

                if (East > -1)
                    Console.WriteLine("\te - österut");

                if (South > -1)
                    Console.WriteLine("\ts - söderut");

                if (West > -1)
                    Console.WriteLine("\tw - västerut");

            }
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rooms of MUD.");

            List<Room> roomsOfMud = new List<Room>();
            int currentRoom = 0;
            string command;
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                if (command.Contains("load"))
                {
                    string[] cmdWithArgs = command.Split(' ');
                    string fileRoot = @"C:\Users\Ägare\";
                    string fullFilePath = fileRoot + cmdWithArgs[1];

                    using (StreamReader sr = new StreamReader(fullFilePath))
                    {
                        while (sr.Peek() > -1)
                        {
                            string line;
                            line = sr.ReadLine();

                            if (line.Contains("//"))
                            { // skip first line if commented with //
                                continue;
                            }

                            string[] mudData = line.Split('|');
                            Room r = new Room(Int32.Parse(mudData[0]),
                                mudData[1],
                                mudData[2],
                                Int32.Parse(mudData[3]),
                                Int32.Parse(mudData[4]),
                                Int32.Parse(mudData[5]),
                                Int32.Parse(mudData[6])
                                );
                            roomsOfMud.Add(r);
                        }
                    }
                    Console.WriteLine($"{roomsOfMud.Count} rooms have been loaded.");

                }
                else if (command == "start")
                {
                    // NYI: start the first room
                    Console.WriteLine("NYI: start the first room");
                    roomsOfMud[currentRoom].Print();
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
                    if (roomsOfMud[currentRoom].North > -1)
                    {

                    }
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