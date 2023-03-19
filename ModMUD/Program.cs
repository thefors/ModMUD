namespace ModMUD
{
    internal class Program
    {
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