/*Дан массив чисел размерностью 10 элементов.
Написать функцию, которая сортирует массив по возрастанию или по убыванию, 
в зависимости от третьего параметра функции.
Если он равен true, сортировка идет по убыванию, если false, то по возрастанию.
Первые 2 параметра функции - это массив и его размер, третий параметр по умолчанию равен false.*/

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Console;

namespace HomeWork_from_slack_20._04._20_task1
{
    class Program
    {
        static void RandomInputArray (int [] arr, int size)
        {
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(0, 100);
            }
        }

        static void ShowArray(int[] arr, int size)
        {
            foreach (var item in arr)
            {
                Write($"{item} \t");
            }

            WriteLine("\n");
        }

        static void Sort(int [] arr, int size, int direct)
        {
            int temp;

            WriteLine($"Укажите порядок сортировки массива \n 0 - по возрастанию \n 1 - по убыванию");
            direct = Convert.ToInt32(ReadLine());

            if (direct == 0)
            {
                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
            }

        }
        

        static void Main(string[] args)
        {
            int direct = 0;
            const int SIZE = 10;
            int[] massive = new int[SIZE];

            RandomInputArray(massive, SIZE);
            ShowArray(massive, SIZE);
            Sort(massive, SIZE, direct);
            ShowArray(massive, SIZE);


        }
    }
}
