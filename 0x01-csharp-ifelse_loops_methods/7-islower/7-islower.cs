using System;

namespace _7_islower
{
    class Character{
        public static bool IsLower(char c){
            int ascii = System.Convert.ToInt32(c);
            if (ascii >= 97 && ascii <= 122)
                return true;
            return false;
        }
    }
}
