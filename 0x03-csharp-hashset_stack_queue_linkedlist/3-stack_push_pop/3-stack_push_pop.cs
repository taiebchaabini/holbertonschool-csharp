using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search){
        var topItem = "";

        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count == 0){
            topItem = "Stack is empty";
        } else{
            topItem = "Top item: " + aStack.Peek();
        }
        Console.WriteLine(topItem);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
        while(aStack.Contains(search)){
            aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}
