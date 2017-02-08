using System;

namespace Test_Triangle_Excersize_1
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                GenerateTriangle t = new GenerateTriangle();
                Console.WriteLine(t.chooseInputs());

                Console.WriteLine("Press escape to quit or any other key to go again");
                if (Console.ReadKey().Key == ConsoleKey.Escape) { Environment.Exit(0); }

            }
        }
    }
}
