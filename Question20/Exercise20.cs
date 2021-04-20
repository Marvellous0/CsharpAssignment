using System;

namespace Question20
{
    public class Question20
    {
        public static void GetCentury()
        {
            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int result = (year / 100) + ((year % 100 == 0) ? 0 : 1);
            Console.WriteLine($"{result} century");
        }
    }
}
