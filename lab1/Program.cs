using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            decimal[] jump_in_height = new decimal[20];
            decimal[] jump_in_length = new decimal[20];
           
            decimal currentMax = decimal.MinValue;     
            for (int i = 0; i < 5; i++)
            {
                jump_in_height[i] = (decimal)(r.NextDouble() * 500);
                jump_in_length[i] = (decimal)(r.NextDouble() * 500);
                Console.WriteLine(jump_in_height[i]);
                Console.WriteLine(jump_in_length[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                if(currentMax < jump_in_height[i])
                {
                    currentMax = jump_in_height[i];
                }
            }
            Console.WriteLine(currentMax);
            
        }
    }
}
