using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList){
        int max = 0;
        string maxKey = "";
        foreach(var pair in myList){
            if (pair.Value > max){
                max = pair.Value;
                maxKey = pair.Key; 
            }
        }
        return maxKey;
    }
}
