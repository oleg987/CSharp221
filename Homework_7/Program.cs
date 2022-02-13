using System;

namespace Homework_7
{
    internal class Program
    {
       
            
        
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            int value = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = value++;
                }
            }
           

                
            Matrix matrix = new Matrix(array);
            matrix.task_903(array);
            matrix.task_904(array);
           
        }
    }
}
