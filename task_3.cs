/*Задание 3:
В функцию передаётся массив случайных чисел в диапазоне от -20 до +20. 
Необходимо найти позиции крайних отрицательных элементов
(самого левого отрицательного элемента и самого правого отрицательного элемента) 
и отсортировать элементы, находящиеся между ними.*/

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Console;

namespace HomeWork_from_slack_20._04._20_task3
{
    class Program
    {
        static void RandomInputArray(int[] arr, int size)
        {
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(-20, 20);
            }
            WriteLine("\n");
        }


        static void ShowArray(int[] arr, int size)
        {
            foreach (var item in arr)
            {
                Write($"{item} \t");
            }
            WriteLine("\n");
        }

        static void Sort (int [] arr, int size, int start, int end)
        {   
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < 0)
                {
                    start = i;
                }
                break;
            }

            for (int j = size - 1; j > 0; j--)
            {
                if (arr[j] < 0)
                {
                    end = j;
                }
                break;
            }

            int temp;

            for (int i = start; i < end - 1; i++)
            {
                for (int j = i + 1; j < end; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            WriteLine("\n");
        }


        static void Main(string[] args)
        {
            const int SIZE = 10;
            int[] massive = new int[SIZE];

            RandomInputArray(massive, SIZE);
            ShowArray(massive, SIZE); 
            Sort(massive, SIZE, -20, 20);
            ShowArray(massive, SIZE);


        }
    }
}
