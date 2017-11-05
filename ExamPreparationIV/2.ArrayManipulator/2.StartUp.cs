using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input.StartsWith("exchange"))
                {
                    int index = int.Parse(input.Substring(9));
                    ExchangeArray(ref arr, index);
                }
                else if (input == "max even")
                {
                    Console.WriteLine(GetMaxEven(arr));
                }
                else if (input == "max odd")
                {
                    Console.WriteLine(GetMaxOdd(arr));
                }
                else if (input == "min even")
                {
                    Console.WriteLine(GetMinEven(arr));
                }
                else if (input == "min odd")
                {
                    Console.WriteLine(GetMinOdd(arr));
                }
                else if (input.StartsWith("first") || input.StartsWith("last"))
                {
                    Console.WriteLine(GetFirstOrLast(arr, input));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", arr) + "]");

        }

        private static string GetFirstOrLast(int[] arr, string input)
        {
            string[] split = input.Split();
            int count = int.Parse(split[1]);
            if (count > arr.Length)
            {
                return "Invalid count";
            }

            int[] filtArr;
            if (split[2] == "even")
            {
                filtArr = arr.Where(x => x % 2 == 0).ToArray();
            }
            else
            {
                filtArr = arr.Where(x => x % 2 != 0).ToArray();
            }

            if (split[0] == "first")
            {
                return "[" + string.Join(", ", filtArr.Take(count).ToArray()) + "]";
            }
            else
            {
                return "[" + string.Join(", ", filtArr.Reverse().Take(count).Reverse().ToArray()) + "]";
            }
        }

        private static string GetMaxEven(int[] arr)
        {
            var filtArr = arr.Where(x => x % 2 == 0).ToArray();
            if (filtArr.Length == 0)
            {
                return "No matches";
            }
            int maxEven = filtArr.Max();
            int index = arr.ToList().LastIndexOf(maxEven);
            return index.ToString();
        }

        private static string GetMaxOdd(int[] arr)
        {
            var filtArr = arr.Where(x => x % 2 != 0).ToArray();
            if (filtArr.Length == 0)
            {
                return "No matches";
            }
            int maxOdd = filtArr.Max();
            int index = arr.ToList().LastIndexOf(maxOdd);
            return index.ToString();
        }

        private static string GetMinEven(int[] arr)
        {
            var filtArr = arr.Where(x => x % 2 == 0).ToArray();
            if (filtArr.Length == 0)
            {
                return "No matches";
            }
            int minEven = filtArr.Min();
            int index = arr.ToList().LastIndexOf(minEven);
            return index.ToString();
        }

        private static string GetMinOdd(int[] arr)
        {
            var filtArr = arr.Where(x => x % 2 != 0).ToArray();
            if (filtArr.Length == 0)
            {
                return "No matches";
            }
            int minOdd = filtArr.Min();
            int index = arr.ToList().LastIndexOf(minOdd);
            return index.ToString();
        }

        private static void ExchangeArray(ref int[] arr, int index)
        {
            if (index >= arr.Length || index < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            var firstPart = arr.Take(index + 1).ToArray();
            var secondPart = arr.Skip(index + 1).ToArray();
            arr = secondPart.Concat(firstPart).ToArray();
        }
    }
}
