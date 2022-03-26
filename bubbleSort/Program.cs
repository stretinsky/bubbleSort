using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(100);
            }

            Console.Write($"Изначальный массив: ");
            foreach (var a in arr) { Console.Write($"{a} "); }
            Console.WriteLine();

            Console.Write($"Отортированный массив: ");
            foreach (var a in BubbleSort(arr)) { Console.Write($"{a} "); }
            Console.WriteLine();
        }
        static int[] BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
