using System;

namespace Question9
{
    public class Question9
    {
        public static void RemoveCharacter()
        {
            Console.WriteLine(remove_char("Fahrenheit", 7));
            Console.WriteLine(remove_char("Fahrenheit", 2));
        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }  
    }
}
