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
                    Console.WriteLine("NYI");
                }
                else if (command == "starta")
                {
                    // NYI: start the first room
                    Console.WriteLine("NYI");
                }
                else if (command == "spara")
                {
                    // NYI: save a room
                    Console.WriteLine("NYI");
                }
                else if (command == "n")
                {
                    // NYI: move north
                    Console.WriteLine("NYI");
                }
                else if (command == "s")
                {
                    // NYI: move south
                    Console.WriteLine("NYI");
                }
                else if (command == "e" || command == "ö")
                {
                    // NYI: move east
                    Console.WriteLine("NYI");
                }
                else if (command == "w" || command == "v")
                {
                    // NYI: move west
                    Console.WriteLine("NYI");
                }
            } while (true);
        }
    }
}