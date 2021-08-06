using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            //НАЧАЛО БЛОКА ДЛЯ 1-5 заданий.
            //Раскомменитировать при проверке заданий от 1 до 5
            //Проверять задания по одному (больше, чем с одного задания не снимать коментарии)
            // Спасибо!
            /*
            sbyte[] array = new sbyte[20];
            Random random = new Random();

             for (sbyte i = 0; i < array.Length; i++)
             {
                 array[i] = (sbyte)random.Next(-100,100);
                 Console.WriteLine(array[i]);

             }

             Console.WriteLine("--------------------------------------------");
            */
            //КОНЕЦ БЛОКА ДЛЯ 1-5 заданий
            //
            //
            //
            //
            //
            //
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

            for (byte i = 0; i < array.Length; i++)
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

            for (byte i = 0; i < array.Length; i++)
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
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------


            //Задание №6
            /*
            int[] arrayA = new int[20];
            int[] arrayB = new int[20];
            int parity;
            int j = 0;
            double sum = 0;

            Random random = new Random();

            for (byte i = 0; i < arrayA.Length; i++)
            {
                arrayA[i] = (int)random.Next(-100,100);
                Console.WriteLine(arrayA[i]);

            }
            Console.WriteLine("/////////////////////////");
            Console.WriteLine("Новый массив↓↓↓");

            for (int i = 0; i < arrayA.Length; i++)
            {
                parity = i % 2;

                if (parity == 0 && arrayA[i] > 0)
                {
                    arrayB[j] = arrayB[j] + arrayA[i];
                    Console.WriteLine(arrayB[j]);
                    j++;
                }
            }

            Console.WriteLine(" ");

            // Находим сумму квадратов↓↓↓
            for (int i = 0; i < arrayB.Length; i++)
            {
                sum = sum + arrayB[i] * arrayB[i];
            }

            Console.WriteLine("Сумма квадратов второго массива = " + sum);
            */


            //-------------------------------------------------------
            //-------------------------------------------------------
            //-------------------------------------------------------


            // Задание №7


        }
    }
}
