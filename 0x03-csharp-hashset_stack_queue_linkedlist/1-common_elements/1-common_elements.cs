using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2){
        List<int> list3 = new List<int>();

        foreach (var elem in list1){
            if (list2.Contains(elem)){
                list3.Add(elem);
            }
        }
        return list3;
    }
}
