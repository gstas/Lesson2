using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            task13(1, 2);
            task14(2, 3);
            task37(5, 1000, 250);
            /*
            task38();
            task44();
            */
        }

        private static void task37(double m1, double m2, double r)
        {
            const double G = 6.67E-11;
            double result = G * ((m1 * m2) / Math.Pow(r, 2));
            Console.WriteLine("Lesson2 task37: " + result);
        }

        private static void task14(double x, double y)
        {
            double result = Math.Pow(2, -1 * x) - Math.Cos(x) + Math.Sin(2 * x * y);
            Console.WriteLine("Lesson2 task14: " + result);
        }

        private static void task13(double x, double y)
        {
            double result = (Math.Cos(x) / (Math.PI - 2 * x)) + 16 * x * Math.Cos(x * y) - 2;
            Console.WriteLine("Lesson2 task13: " + result);
        }

    }
}
