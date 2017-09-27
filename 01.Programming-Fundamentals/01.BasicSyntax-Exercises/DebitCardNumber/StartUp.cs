
namespace ProgrammingFundamentals
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());
            int fourthDigit = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:D4} {0:D4}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        }
    }
}
