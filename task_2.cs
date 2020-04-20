/*Задание 2:
Написать функцию, которая сортирует первую половину массива по убыванию, 
а вторую - по возрастанию, используя сортировку пузырьком.*/

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Console;

namespace HomeWork_from_slack_20._04._20_task2
{
    class Program
    {
        static void RandomInputArray(int [] arr, int size)
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

        static void Sort (int [] arr, int size)
        {
            int temp;

            for (int i = 0; i < (size / 2) - 1; i++)
            {
                for (int j = i + 1; j < size / 2; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            for (int i = size / 2; i < size -1; i++)
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

            WriteLine("\n \n");
        }

        static void Main(string[] args)
        {
            const int SIZE = 10;
            int[] massive = new int[SIZE];

            RandomInputArray(massive, SIZE);
            ShowArray(massive, SIZE);
            Sort(massive, SIZE);
            ShowArray(massive, SIZE); ;
        }
    }
}
