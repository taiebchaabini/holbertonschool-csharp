using System;

namespace _0_print_array
{
    class Array
    {
        static void Main(string[] args)
    {
        int[] newArray;

        newArray = Array.CreatePrint(10);
        Console.WriteLine("Array Length:" + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(16);
        Console.WriteLine("Array Length:" + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(0);
        Console.WriteLine("Array Length:" + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(-10);
    }
        public static int[] CreatePrint(int size)
        {

            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write(i);
                if (i != size - 1)
                {
                    Console.Write(" ");
                }
                arr[i] = i;
            }

            Console.Write("\n");

            return arr;
        }
    }
}
