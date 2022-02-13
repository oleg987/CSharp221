using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    public class Matrix
    {
        public int[,] Value { get; set; }
        public Matrix(int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Value = new int[size, size];
        }
        public Matrix(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (array.GetLength(0) != array.GetLength(1))
            {
                throw new ArgumentException();
            }
            Value = array;
        }
        
        public int task_903(int[,] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException();
            }
            if (array.GetLength(0) != Value.GetLength(0) || array.GetLength(1) != Value.GetLength(1))
            {
                throw new ArgumentException();
            }
            int sum = 0;
            for (int rows = 0; rows < Value.GetLength(0); rows++)
            {
                for (int cols = 0; cols < Value.GetLength(1); cols++)
                {
                    if (array[rows, cols] % 2 == 0)
                    {
                        sum = sum + array[rows, cols];
                    }

                }

            }
            return sum;
        }
        public int task_904(int[,] array)
        {

            int max = int.MinValue;

            for (int i = 0; i < Value.GetLength(0); i++)
            {
                for (int j = 0; j < Value.GetLength(1); j++)
                {

                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }

                }
            }
            return max;

        }
    }
}