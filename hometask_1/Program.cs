using System;

namespace hometask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //13
            Console.Write("Enter value of kurs: ");
            double kurs = double.Parse(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                double grivna = i * kurs;
                Console.WriteLine($"{i} dollar(s) is {grivna} grivna");
            }
            //15
            for (int i = 1; i <= 10; i++)
            {
                int result = i * 7;
                Console.WriteLine($"{i}*7 = {result}");
            }

        }

    }
}


