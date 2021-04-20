using System;
using System.Linq;

namespace Question22
{
    public class Question22
    {
        public static void CheckNumbers()
        {
            Console.WriteLine(test(new[] { 9, 34, 7, 3 }, 3));
            Console.WriteLine(test(new[] { 1, 2, 76, 3 }, 2));
            Console.WriteLine(test(new[] { 1, 2, 2, 3 }, 9));
            Console.ReadLine();
        }
        public static bool test(int[] numbers, int n)
        {
            if (numbers.Contains(n))
            {
                return true;
            }
            return false;
        }
    }
}
