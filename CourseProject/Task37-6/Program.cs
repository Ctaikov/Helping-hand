using System;

namespace Task37_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers for the variables c, z, x, t, v.");
            Console.Write("c:");
            double c = double.Parse(Console.ReadLine());
            Console.Write("z:");
            double z = double.Parse(Console.ReadLine());
            Console.Write("x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("t:");
            double t = double.Parse(Console.ReadLine());
            Console.Write("v:");
            double v = double.Parse(Console.ReadLine());
            bool equation = (0.17 * Math.Pow(c, 3) - 1 <= 0 + z * (-x + t) + (-v));
            Console.WriteLine("The answer to the equation is: " + equation);
        }
    }
}
