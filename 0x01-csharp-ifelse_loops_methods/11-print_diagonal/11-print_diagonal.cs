using System;
using System.Text;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length)
        {
            var output = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                output.Clear();
                output.Insert(0, " ", i);
                Console.Write($"{output}\\\n");
            }
            Console.Write("\n");
        }
    }
}
