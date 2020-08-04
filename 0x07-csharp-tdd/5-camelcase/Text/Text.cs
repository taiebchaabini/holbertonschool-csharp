using System;

namespace Text
{
     /// <summary>Represents a Str class.</summary>
    public class Str
    {
        /// <summary>Determines how many words are in a string</summary>
        /// <param name="s">String to check.</param>
        /// <returns>returns number of words in s.</returns>
        public static int CamelCase(string s){
            if (s == null){
                return 0;
            }
            if (s.Length == 0){
                return 0;
            }
            string[] list = s.Split(' ');
            int i = 0;
            int n = 0;
            if (list.Length == 1 && !Char.IsLetter(s[0]))
                return 0;
            if (list.Length == 1){
                return 1;
            }
            if (list.Length > 1 && Char.IsLetter(s[0])){
                n += 1;
            }
            foreach (var str in list){
                try{
                    if (Char.IsLetter(str[0]) && i > 0 && Char.IsUpper(str[0]) && str.Length >= 2)
                        n += 1;
                }
                catch{
                    continue;
                }
                i += 1;
            }
            return n;
        }
    }
}
