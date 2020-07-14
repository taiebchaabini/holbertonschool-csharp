using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++){
                for (int b = i + 1; b < 10; b++){
                    if (i == 8 && b == 9)
                        Console.Write($"{i}{b}\n");
                    else
                        Console.Write($"{i}{b}, ");
                }
            }
        }
    }
}
