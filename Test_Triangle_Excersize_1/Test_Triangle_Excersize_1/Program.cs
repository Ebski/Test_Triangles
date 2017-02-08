using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Triangle_Excersize_1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            GenerateTriangle t = new GenerateTriangle();
            Console.WriteLine(t.chooseInputs());

            Console.WriteLine("Press escape to quit");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
        }
    }
}
