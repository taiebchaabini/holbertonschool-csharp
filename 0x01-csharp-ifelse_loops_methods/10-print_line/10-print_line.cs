using System;
using System.Text;

namespace _10_print_line
{
    class Line
    {
        public static void PrintLine(int length){
            var output = new StringBuilder();
            for (int i = 0; i < length; i++){
                output.Append("_");
            }
            Console.Write($"{output}\n");
        }
    }
}
