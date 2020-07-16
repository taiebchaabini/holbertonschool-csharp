using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] arr = new int[size];
        var output = new StringBuilder();
        for (int i = 0; i < size; i++)
        {
            output.append(i);
            if (i != size - 1)
            {
                output.Append(" ");
            }
            arr[i] = i;
        }

        Console.WriteLine(output);

        return arr;
    }
}
