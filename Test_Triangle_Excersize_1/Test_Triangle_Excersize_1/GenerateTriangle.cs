using System;

namespace Test_Triangle_Excersize_1
{
    public class GenerateTriangle
    {

        public string chooseInputs()
        {
            int a;
            int b;
            int c;

            try
            {
                Console.WriteLine("Creating a triangle on 3 inputs");
                Console.WriteLine("Write length of first side of the triangle");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Write length of second side of the triangle");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Write length of third side of the triangle");
                c = int.Parse(Console.ReadLine());
            }
            catch(FormatException) // Caches decimals, strings and numbers over max Integer size
            {
                return "Invalid input";
            }

            return generate(a, b, c);
        }
        public string generate(int a, int b, int c)
        {
            bool triangle;
            if (a <= 0 || b <= 0 || c <= 0) { return "Invalid input"; }
            triangle = isTriangle(a, b, c);
            if (!triangle) { return "Not a triangle"; }
            else { return checkTriangle(a, b, c); }
            
        }

        private bool isTriangle(int a, int b, int c)
        {
            if (a > b && a > c && a > b + c)
            {
                return false;
            }
            if (b > a && b > c && b > a + c)
            {
                return false;
            }
            if (c > a && c > b && c > a + b)
            {
                return false;
            }
            return true;
        }

        private string checkTriangle(int a, int b, int c)
        {
            if (a == b && a == c)
            {
                return "Equilateral triangle";
            }
            else if (a == b || a == c || b == c)
            {
                return "Isosceles triangle";
            }
            else
            {
                return "Scalene triangle";
            }
        }
    }
}