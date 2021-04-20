using System;

namespace Question2
{
    public class Question2
    {
        public static void SwapMethod()  
            {  
                int  a = 5, b = 10;            
                Console.WriteLine("a = "+a+" b = "+b);

                a = a * b;      
                b = a / b;      
                a = a / b;    
                Console.WriteLine("a = "+a+" b = "+b);       
            }  
    }
}
