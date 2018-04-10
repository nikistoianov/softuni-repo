using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Main
{
    class Program
    {
        static void Main()
        {
            int[] parameters = { 5, 10, 28, 33, 7, 3 };
            DoubleQuestionmark(new string[]{ "1", "2"});
            DoubleQuestionmark(null);
            //string input = @"<html><head><title></title></head><body><h1>hello</h1><p>znahny!@#%&&&&****</p><div><button>dsad</button></div><p>grkg^^^^%%%)))([]12</p></body></html>";
            //Console.WriteLine(String.Join(", ", ExtractBetweenTags(input, "button")));

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

        private static void DoubleQuestionmark(string[] parameters)
        {
            //var result = parameters ?? throw new ArgumentException("Input cannot be null!");
            var result = parameters ?? new string[3];
            //var result = new string[3] ?? parameters;
        }

        private static string[] ExtractBetweenTags(string input, string tag)
        {
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
