﻿namespace RectangleArea
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;

            Console.WriteLine("{0:F2}", area);
        }
    }
}
