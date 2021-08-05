using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
          

            sbyte[] array = new sbyte[20];
            Random random = new Random();

             for (sbyte i = 0; i < array.Length; i++)
             {
                 array[i] = (sbyte)random.Next();
                 Console.WriteLine(array[i]);

             }

             Console.WriteLine("--------------------------------------------");
            //----------------------------------------------------------------


            // Задание№1

            /* for (int i = 0; i < array.Length; i++)
             {
                 if (array[i] < array[i+1])
                 {
                     Console.WriteLine(array[i+1]);
                 }
             } */

            //-----------------------------------------------------


            // Задание №2
            /*
            sbyte max = -128;
            sbyte min = 127;
            int indexMax = -1;
            int indexMin = -1;


            for (byte i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }

                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                }
            }

            Console.WriteLine("Maximum = " + max + " Его индекс = " + indexMax);
            Console.WriteLine("Minimum = " + min + " Его индекс = " + indexMin);

            array[indexMax] = min;
            array[indexMin] = max;

            Console.WriteLine();
            Console.WriteLine("массив изменен ");
            Console.WriteLine();

            for (byte i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            */



            //-------------------------------------------------


            // Задание №3
            /*

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    Console.WriteLine("первый положительный член массива под индексом - " + i
                            + " его значение = " + array[i]);
                    break;
                }
            }
            */

            //--------------------------------------------------


            //Задание №4
            /*
            double min = 0;
            double indexMin = -1;
            double z;

            for (sbyte i = 0; i < array.Length; i++)
            {
                z = i % 2;
                if (z != 0)
                {
                    if (min > array[i])
                    {
                        min = array[i];
                        indexMin = i;
                    }
                }
            }

            Console.WriteLine("Индеск элемента - " + indexMin + " Значение элемента = " + min);
            */

            //--------------------------------------------------------


            //Задание №5
            /*
            double sum = 0;

            for (sbyte i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            sum = sum / 20;

            Console.WriteLine("Среднее арифметическое = " + sum);

            for (int i = 0; i < array.Length; i++)
            {
                if (sum < array[i])
                {
                    Console.WriteLine("Этот элемент больше среднего арифметического - " + array[i]);
                }
            }
            */

            //------------------------------------------------------------------------
        }
    }
}
