using System;

namespace Task209
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 132;
            int[] array = new int[100];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(Min, Max);
                if (array[i]<26 || array[i]>100)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
