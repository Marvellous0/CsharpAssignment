using System;

namespace Question12
{
    public class Question12
    {
            public static void MultiplicatioOfArrays()
            {
                int[] num1 = { 10, 5, -2, 7 };
                int[] num2 = { 3, -8, 9, 8 };

                for (int i = 0; i < num1.Length; i++)
                {
                    double result = num1[i] * num2[i];
                    Console.WriteLine($"Result = {result}");
                }
            }
    }
}
