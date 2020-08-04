using System;

namespace Text
{
     /// <summary>Represents a Str class.</summary>
    public class Str
    {
        /// <summary>Checks the index of the first non-repeating character of a string</summary>
        /// <param name="s">String to check.</param>
        /// <returns>returns the index of the first non-repeating character of a string.</returns>

        public static int CamelCase(string s){
            if (s == null){
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
                if (Char.IsLetter(str[0]) && i > 0 && Char.IsUpper(str[0]))
                    n += 1;
                i += 1;
            }
            return n;
        }
    }
}
