using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsInstanceOfArray(object obj){
        if (obj.GetType() == typeof(Array) || obj is Array)
            return true;
        return false;
    }
}
