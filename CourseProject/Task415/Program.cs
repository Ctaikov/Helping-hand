using System;

namespace Task415
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=1;
            int[] array = new int[10];
            Console.WriteLine("Enter the elements for your array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] % 3 == 0 && (array[j]>=0 || array[j]<=50))
                {
                    sum = sum * array[j];
                }
                
            }
            Console.WriteLine(sum);
        } 
    }
}
