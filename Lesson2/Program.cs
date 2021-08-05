using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
                Console.WriteLine(array[i]);

            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[i+1])
                {
                    Console.WriteLine(array[i+1]);
                }
            }
        }
    }
}
