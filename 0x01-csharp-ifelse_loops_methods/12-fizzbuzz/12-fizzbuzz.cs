using System;
using System.Text;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = new StringBuilder();
            for (int i = 1; i <= 100; i++){
                if (i % 3 == 0 && i % 5 == 0){
                    output.Append("FizzBuzz");
                }
                else if (i % 3 == 0){
                    output.Append("Fizz");
                }
                else if (i % 5 == 0){
                    output.Append("Buzz");
                }
                else{
                    output.Append($"{i}");
                }
                if (i != 100){
                    output.Append(" ");
                }
            }
            Console.WriteLine(output);
        }
    }
}
