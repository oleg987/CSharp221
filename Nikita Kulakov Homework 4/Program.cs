using System;

namespace Nikita_Kulakov_Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //task 9

            int[] a = new int[20];

            int b = rnd.Next(0, 20);

            bool repeat;

            bool canContinue;

            for(int x = 0; x < a.Length; x++)
            {
                repeat = false;
                canContinue = false;

                while (canContinue == false)
                {
                    b = rnd.Next(0, 20);

                    for (int y = 0; y < x; y++)
                    {
                        if (b == a[y])
                        {
                            repeat = true;
                        }
                    }

                    if (repeat == false)
                    {
                        a[x] = b;
                        canContinue = true;
                    }
                }

                Console.WriteLine(a[x]);
            }

            Console.WriteLine("\n");



            //task 38

            int[] a2 = new int[20];

            for (int x = 0; x < a2.Length; x++)
            {
                a2[x] = rnd.Next(0, 100);
                Console.WriteLine(a2[x]);
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            int b2 = 0;

            int currentNuber = 0;

            for (int x = 0; x < a2.Length; x++)
            {
                currentNuber = a2[x];

                if (a2[x] % 2 == 0)
                {
                    b2 = x;

                    while (true)
                    {
                        if (b2 < 20)
                        {
                            if (a2[b2] % 2 != 0)
                            {
                                a2[x] = a2[b2];
                                a2[b2] = currentNuber;
                                break;
                            }
                            else if (a2[b2] % 2 == 0)
                            {
                                b2++;
                            }
                        }
                        else if (b2 > 20)
                        {
                            if (a2[b2] % 2 != 0)
                            {
                                a2[x] = a2[b2];
                                a2[b2] = currentNuber;
                                break;
                            }
                            else if (a2[b2] % 2 == 0)
                            {
                                b2--;
                            }
                        }
                    }
                }
                else if (a2[x] % 2 != 0)
                {
                    b2 = x;

                    while (true)
                    {
                        if (b2 < 20)
                        {
                            if (a2[b2] % 2 == 0)
                            {
                                a2[x] = a2[b2];
                                a2[b2] = currentNuber;
                                break;
                            }
                            else if (a2[b2] % 2 != 0)
                            {
                                b2++;
                            }
                        }
                        else if (b2 > 20)
                        {
                            if (a2[b2] % 2 == 0)
                            {
                                a2[x] = a2[b2];
                                a2[b2] = currentNuber;
                                break;
                            }
                            else if (a2[b2] % 2 != 0)
                            {
                                b2--;
                            }
                        }
                    }
                }
            }

            for (int x = 0; x < a2.Length; x++)
            {
                Console.WriteLine(a2[x]);
            }
        }
    }
}
