using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 23, 13, 45, 65, 4 };
            bubbleSort(arr);
            Console.WriteLine("Your Sorted Array");
            printArray(arr);
        }
       static void bubbleSort(int [] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            
                for (int j = 0; j < n-i-1; j++)
                    if (arr[j] > arr[j +1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }               
           
        }
        static void printArray(int [] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " " );
            Console.WriteLine();
        }
    }
}
