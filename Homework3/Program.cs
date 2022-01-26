using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool canContinue = true;

            //Task 1
            Console.WriteLine("task 1");
            Console.WriteLine("Enter number:");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            string c = "";

            if (b <= 0)
            {
                Console.WriteLine("Number must be natural");
                canContinue = false;
            }

            if (canContinue)
            {
                for (int i = a.Length; i > 0; i--)
                {
                    c += a[i-1];
                }

                Console.WriteLine(c);
            }

            //Task 2
            if (canContinue)
            {
                Console.WriteLine("\n" + "task 2");
                Console.WriteLine("Enter number:");
                string a2 = Console.ReadLine();
                int b2 = Convert.ToInt32(a2);
                int c2 = 1;

                while(c2 < b2)
                {
                    if(b2 % c2 == 0)
                    {
                        Console.WriteLine(c2);
                    }

                    c2 += 1;
                }
            }

            //Task 3
            if (canContinue)
            {
                Console.WriteLine("\n" + "task 3");
                Console.WriteLine("Enter number:");
                string a3 = Console.ReadLine();
                int b3 = Convert.ToInt32(a3);

                while(b3 > 0)
                {
                    bool e = perfectNumber(0, b3, 1);

                    if (e && b3 <= Convert.ToInt32(a3))
                    {
                        Console.WriteLine(b3);
                    }

                    b3 -= 1;
                }
            }
        }

        static bool perfectNumber(int x, int y, int z)
        {
            z = 1;

            while (z < y)
            {
                x = 0;

                if (y % z == 0)
                {
                    x += z;
                }

                z += 1;
            }

            if(x == y)
                return true;
            else
                return false;
        }
    }
}
