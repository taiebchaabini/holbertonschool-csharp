﻿using System;
using System.Collections.Generic;

class Obj
{
    public static bool IsOfTypeInt(object obj){
        if (obj.GetType() == typeof(int)){
            return true;
        }
        return false;
    }
}