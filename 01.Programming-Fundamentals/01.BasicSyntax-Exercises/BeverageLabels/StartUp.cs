namespace BeverageLabels
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double totalEnergy = volume * energy / 100;
            double totalSugar = volume * sugar / 100;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);

        }
    }
}
