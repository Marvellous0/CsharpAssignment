using System;

namespace Question3
{
    public class Question3
    {
        public static void Multiples()
            {
                int a,i;
                Console.WriteLine("Multiples of 7 are : ");
                 for (i = 1; i < 1000; i++)
                 {
                    a = i % 7;
                        if (a == 0)
                        {
                            Console.WriteLine(i);
                        }
                }

            }
    }
}
