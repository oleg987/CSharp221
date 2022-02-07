using System;

namespace homework_5
{
    internal class Program
    {
        public static void task_903()
        {
            int[,] arr = new int[10, 10];
            Random r = new Random();
            for (int rows = 0; rows < 10; rows++)
            {
                for (int cols = 0; cols < 10; cols++)
                {
                    arr[rows, cols] = r.Next(10);
                    Console.Write(arr[rows, cols] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int rows = 0; rows < 10; rows++)
            {
                for (int cols = 0; cols < 10; cols++)
                {
                    if (arr[rows, cols] % 2 == 0)
                    {
                        sum = sum + arr[rows, cols];
                    }

                }

            }
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine();
        }
            public static void task_904()
            {
                int m;
                int n;
                m = 3;
                n = 3;
                double[,] arr = new double[m, n];
                Random r = new Random();
                double min = int.MaxValue;
                double max = int.MinValue;
                for (m = 0; m < arr.GetLength(0); m++)
                {
                    for (n = 0; n < arr.GetLength(1); n++)
                    {
                        arr[m, n] = r.NextDouble();
                        Console.Write(arr[m, n] + "\t");
                    }
                    Console.WriteLine();
                }
                for (m = 0; m < arr.GetLength(0); m++)
                {
                    for (n = 0; n < arr.GetLength(1); n++)
                    {
                        if (min > arr[m, n])
                        {
                            min = arr[m, n];
                        }
                        if (max < arr[m, n])
                        {
                            max = arr[m, n];
                        }

                    }
                }
                Console.WriteLine($"Minimum is {min}");
                Console.WriteLine($"Maximum is {max}");
                Console.WriteLine();

            
       }
        public static void task_906()
        {
            Random r = new Random();
            double sum = 0;
            double[,] C = new double[15, 15];
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    C[i, j] = r.NextDouble();
                    C[i, j] = Math.Round(C[i, j], 3);
                    Console.Write(C[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int k = -1;
            int g = -1;
            for (int i = 0; i < 15; i++)
            {

                k++;
                g++;
                if (k == 15 && g == 15)
                {
                    break;
                }


                for (int j = k; j < g + 1; j++)
                {
                    sum = sum + C[i, j];
                }

            }
            Console.WriteLine(sum);
        }
        public static void task_907()
        {
            int[,] arr = new int[5, 5];
            Random r = new Random();
            for (int rows = 0; rows < 5; rows++)
            {
                for (int cols = 0; cols < 5; cols++)
                {
                    arr[rows, cols] = r.Next(10);
                    Console.Write(arr[rows, cols] + "\t");
                }
                Console.WriteLine();
            }

            int g = 0;
            int k = -1;
            
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            for (int rows = 1; rows < 5; rows++)
            {
                g++;
                k++;
               
                if (g == 5 )
                {
                    break;
                }
                for (int cols = k; cols < g; cols++)
                {
                   
                    sum1 = sum1 + arr[rows, cols];
                    if (g + 1 < 5 )
                    {
                        sum2 = sum2 + arr[g + 1, cols];
                    }


                    if (g + 2 < 5) {
                        sum3 = sum3 + arr[g + 2, cols];
                    }
                    if (g + 3 < 5)
                    {
                        sum4 = sum4 + arr[g + 3, cols];
                    }
                    
                }
            }
            

            Console.WriteLine();
            Console.WriteLine(sum1);
            Console.WriteLine();
            Console.WriteLine(sum2);
            Console.WriteLine();
            Console.WriteLine(sum3);
            Console.WriteLine();
            Console.WriteLine(sum4);
            Console.WriteLine();


            
        }
        public static void task_908()
        {
            double[,] arr = new double[5, 5];
            Random r = new Random();
            for (int rows = 0; rows < 5; rows++)
            {
                for (int cols = 0; cols < 5; cols++)
                {
                    arr[rows, cols] = r.NextDouble();
                    arr[rows, cols] = Math.Round(arr[rows, cols], 3);
                    Console.Write(arr[rows, cols] + "\t");
                }
                Console.WriteLine();
            }

            int g = 0;
            double sum = 0;
            for (int rows = 0; rows < 5; rows++)
            {
                g++;
                if (g == 5)
                {
                    break;
                }
                for (int cols = g; cols < 5; cols++)
                {
                    sum = sum + arr[rows, cols];

                }
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            task_903();
            task_904();
            task_906();
            task_907();
           // task_908();
            








          


        }
    }
}
