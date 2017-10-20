using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefulMethods
{
    class Program
    {
        static void Main()
        {
            bool isTrue = false;
            string  test = isTrue ? "Yes" : "No";
            Console.WriteLine(test);

            double km = 1.60934;
            Console.WriteLine($"{km:F2}");
            Console.WriteLine($"{km:00.00}");

            Console.WriteLine(new string('*', 5));

            int index = 64;
            char outputChar = (char)index;
            Console.WriteLine(outputChar + " ");
        }
    }
}



public class Rectangle
{
    public int Top { get; set; }
    public int Left { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int Right { get { return Left + Width; } }
    public int Bottom { get { return Top + Height; } }

}
