using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main()

        {
            double cash = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double priceBanana = double.Parse(Console.ReadLine());
            double priceEgg = double.Parse(Console.ReadLine());
            double priceBarries = double.Parse(Console.ReadLine());

            int sets = (int)Math.Ceiling((double)guests / 6);
            double priceAll = (2 * priceBanana + 4 * priceEgg + 0.2 * priceBarries) * sets;

            if (priceAll <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {priceAll:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(priceAll - cash):F2}lv more.");
            }
        }
    }
}
