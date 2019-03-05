using System;

namespace Task360
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool isNumeric = int.TryParse("123", out n);
            Console.WriteLine(isNumeric);
        }
    }
}
