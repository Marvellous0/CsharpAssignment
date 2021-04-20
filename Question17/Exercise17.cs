using System;

namespace Question17
{
    public class Question17
    {
        public static void SumOfArray()
        {
            int[] num = new int[] { 9, 28, 23, 4, 7 };
            int sum = 0;


            Console.Write("The sum of ");

            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];

                Console.Write(num[i]);

                    if (i < num.Length - 1) 
                    {Console.Write(" + ");}
            }
            Console.WriteLine($" = {sum}");
        }
    }
}
