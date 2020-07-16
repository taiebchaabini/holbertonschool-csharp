using System;
using System.Text;
using System.Collections.Generic;
class List
{
    public static List<int> CreatePrint(int size){
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> myList = new List<int>();
        var output = new StringBuilder();
        for (int i = 0; i < size; i++)
        {
            myList.Add(i);
            output.Append(i);
            if (i != size)
                output.Append(" ");
        }
        Console.WriteLine(output);
        return myList;
    }
}
