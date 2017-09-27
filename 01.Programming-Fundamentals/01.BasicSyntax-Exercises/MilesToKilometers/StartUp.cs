namespace MilesToKilometers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double miles = double.Parse(Console.ReadLine());

            double km = miles * 1.60934;

            Console.WriteLine("{0:F2}", km);
        }
    }
}
