using System;

namespace homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Task 1");
                int[] arr = new int[8];
                arr[0] = 37;
                arr[1] = 0;
                arr[2] = 50;
                arr[3] = 46;
                arr[4] = 34;
                arr[5] = 46;
                arr[6] = 0;
                arr[7] = 13;
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine("Task 2");
                int[] arr2 = new int[10];
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.WriteLine(arr2[i]);
                }

                Console.WriteLine();
                Console.WriteLine("Task 4");
                int[] arr4 = new int[12];
                Random r1 = new Random();
                for (int i = 0; i < 12; i++)
                {
                    arr4[i] = r1.Next(163, 191);
                    Console.WriteLine(arr4[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Task 5");
                int[] arr5 = new int[12];
                int a = 1;
                for (int i = 0; i < 12; i++)
                {

                    arr5[i] = a++;
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine(arr5[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Task 6");
                int[] arr6 = new int[20];
                int b = 20;
                for (int i = 0; i < 20; i++)
                {

                    arr6[i] = b--;
                }
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine(arr6[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Task 12");
                int[] arr7 = new int[5] { 1, 2, 3, 4, 5 };
                Console.Write("Index:");
                int index = int.Parse(Console.ReadLine());


                Console.WriteLine($"Element:{arr7[index]}");
                Console.WriteLine();

                Console.WriteLine("Task 20");
                int[] arr8 = new int[20];
                int sum = 0;
                Random r2 = new Random();
                for (int i = 0; i < 20; i++)
                {
                    arr8[i] = r2.Next(1, 3000);
                    Console.WriteLine(arr8[i]);
                    sum += arr8[i];
                }

                Console.WriteLine($"Sum is:{sum}");

                Console.WriteLine("Task 79");
                int[] arr9 = new int[28];
                int counter = 0;
                Random r3 = new Random();
                for (int i = 0; i < 28; i++)
                {
                    arr9[i] = r3.Next(1, 12);
                    Console.WriteLine(arr9[i]);
                    if (arr9[i] == 2)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"Количество двоек в классе: {counter}");
                Console.WriteLine();

                Console.WriteLine("Task 63");
                int[] arr10 = new int[15];
                int multiplication = 1;
                Random r4 = new Random();

                for (int i = 0; i < 15; i++)
                {
                    arr10[i] = r4.Next(-3000, 3000);
                    Console.WriteLine(arr10[i]);

                    if (arr10[i] % 9 == 0)
                    {
                        multiplication = multiplication * arr10[i];

                    }
                }
                Console.WriteLine($"multiplication is {multiplication}");
                Console.WriteLine();
                Console.WriteLine("Task 62");
                int[] arr11 = new int[15];
                int summury = 0;
                Random r5 = new Random();

                for (int i = 0; i < 15; i++)
                {
                    arr11[i] = r5.Next(-3000, 3000);
                    Console.WriteLine(arr11[i]);

                    if (arr11[i] % 2 == 0)
                    {
                        summury = summury + arr11[i];

                    }
                }
                Console.WriteLine($"Sum of even numbers is {summury}");
                Console.WriteLine();
                Console.WriteLine("Task 164");
                int[] jump_in_height = new int[30];
                int[] jump_in_length = new int[30];
                Random r6 = new Random();
                for (int i = 0; i < 30; i++)
                {
                    jump_in_height[i] = r6.Next(30, 245);
                    jump_in_length[i] = r6.Next(1, 14);
                }
                Array.Sort(jump_in_height);
                Array.Sort(jump_in_length);
                Console.WriteLine($"The best three results for jumping in height are:{jump_in_height[jump_in_height.Length - 1]},{jump_in_height[jump_in_height.Length - 2]},{jump_in_height[jump_in_height.Length - 3]} and the worst three results are:{jump_in_height[0]},{jump_in_height[1]},{jump_in_height[2]}");
                Console.WriteLine($"The best three results for jumping in length are:{jump_in_length[jump_in_length.Length - 1]},{jump_in_length[jump_in_length.Length - 2]},{jump_in_length[jump_in_length.Length - 3]} and the worst three results are:{jump_in_length[0]},{jump_in_length[1]},{jump_in_length[2]}");
                task_71();
                task_72();
                Console.WriteLine();
                Console.WriteLine("Task 112");

                int[] arr14 = new int[10];

                Random r9 = new Random();
                int MIN = int.MaxValue;
                int MAX = int.MinValue;



                for (int i = 0; i < arr14.Length; i++)
                {
                    arr14[i] = r9.Next(1, 10);
                    if (MIN > arr14[i])
                    {
                        MIN = arr14[i];

                    }
                    if (MAX < arr14[i])
                    {
                        MAX = arr14[i];

                    }
                    Console.WriteLine(arr14[i]);

                }
                int v = Array.IndexOf(arr14, MIN);

                arr14[v] = MAX;
                Console.WriteLine();

                for (int i = 0; i < arr14.Length; i++)
                {
                    Console.WriteLine(arr14[i]);
                }
            }
            public static void task_71()
            {
                Console.WriteLine();
                Console.WriteLine("Task 71");
                int[] arr12 = new int[15];

                int sum2 = 0;

                Random r7 = new Random();
                arr12[0] = r7.Next(0, 10);
                Console.WriteLine(arr12[0]);
                int p = 0;
                for (int i = 1; i < arr12.Length; i++)
                {

                    arr12[i] = r7.Next(0, 10);
                    Console.WriteLine(arr12[i]);
                }

                for (int i = 1; i < arr12.Length; i++)
                {

                    if (arr12[i] > arr12[0] * arr12[0])
                    {

                        sum2 = sum2 + arr12[i];




                    }
                    else if (arr12[i] < arr12[0] * arr12[0])
                    {
                        p++;

                    }


                }
                if (p == arr12.Length - 1)
                {
                    Console.WriteLine("Поиск неудачный");
                    return;
                }
                Console.WriteLine($"Sum is: {sum2} ");


            }
            public static void task_72()
            {
                Console.WriteLine();
                Console.WriteLine("Task 72");

                double[] arr13 = new double[10];
                double multiplication2 = 0.1;


                Random r8 = new Random();
                arr13[0] = r8.NextDouble();
                Console.WriteLine(arr13[0]);
                for (int i = 1; i < arr13.Length; i++)
                {
                    arr13[i] = r8.NextDouble();
                    Console.WriteLine(arr13[i]);
                }
                for (int i = 1; i < arr13.Length; i++)
                {
                    if (arr13[i] > arr13[0] && arr13[i] < arr13[3])
                    {
                        multiplication2 = 10 * multiplication2 * arr13[i];

                    }
                    else if (arr13[i] < arr13[0] || arr13[i] > arr13[3])
                    {
                        Console.WriteLine("There are not such numbers");
                        return;
                    }
                }

                Console.WriteLine(multiplication2);
            }
        }
    }

