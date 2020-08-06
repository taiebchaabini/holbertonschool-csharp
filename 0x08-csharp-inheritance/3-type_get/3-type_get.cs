using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>Represents the class Obj.</summary>
class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">Object from where to get informations.</param>
    public static void Print(object myObj){
        TypeInfo t = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
        IEnumerable<MethodInfo> mList = t.DeclaredMethods;
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach (var p in pList)
        {
            Console.Write(p.IsSpecialName + ": ");
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach (var m in mList)
        {
            Console.WriteLine(m.Name);
        }

    }
}
