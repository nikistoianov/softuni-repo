using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UsefulMethods
{
    class Program
    {
        static void Main()
        {
            string input = @"<html><head><title></title></head><body><h1>hello</h1><p>znahny!@#%&&&&****</p><div><button>dsad</button></div><p>grkg^^^^%%%)))([]12</p></body></html>";
            Console.WriteLine(String.Join(", ", ExtractBetweenTags(input, "button")));
            //bool isTrue = false;
            //string  test = isTrue ? "Yes" : "No";
            //Console.WriteLine(test);

            //double km = 1.60934;
            //Console.WriteLine($"{km:F2}");
            //Console.WriteLine($"{km:00.00}");

            //Console.WriteLine(new string('*', 5));

            //int index = 64;
            //char outputChar = (char)index;
            //Console.WriteLine(outputChar + " ");
        }

        private static string[] ExtractBetweenTags(string input, string tag)
        {
            //string pattern = $@"(\<{tag}.*?\>)(.*?)(\<\/{tag}\>)";
            string pattern = $@"(<{tag}>)(?<message>.*?)(<\/{tag}>)";
            Regex msgRegex = new Regex(pattern);
            var result = msgRegex.Matches(input)
                .Cast<Match>()
                .Select(x => x.Groups["message"].Value)
                .ToArray();
            
            return result;
        }

        static double GetDistance(double X1, double Y1, double X2, double Y2)
        {
            return Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
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
