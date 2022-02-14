//Artem Mochuliak
using System;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double win = 0;
            Console.Write("Enter your age,please: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.Write("Enter value of your bet,please: ");
                int bet = int.Parse(Console.ReadLine());
                if (bet < 5 || bet > 100 || bet % 5 != 0)
                {
                    Console.WriteLine("Invalid bet!");
                }
                else
                {
                    Random r = new Random();
                    int number1 = r.Next(1, 10);
                    int number2 = r.Next(1, 10);
                    int number3 = r.Next(1, 10);
                    Console.WriteLine($"Combination:{number1}{number2}{number3}");
                    if (number1 == number2 && number2 == number3 && number1 != 7)
                    {
                        win = number1 * 10 * 1.5;

                    }
                    else if (number1 == number2 && number2 == number3 && number1 == 7)
                    {
                        win = 150 * 1.5;
                    }
                    else if (number1 == number2 && number1 != 7)
                    {
                        win = number1 * 1.25;
                    }
                    else if (number1 == number2 && number1 == 7)
                    {
                        win = 15 * 1.25;
                    }
                    else if (number1 == 7 || number2 == 7 || number3 == 7)
                    {
                        win = 1.6;
                    }
                    else if (number1 == 9 || number2 == 9 || number3 == 9)
                    {
                        win = 1.35;
                    }

                    else
                    {
                        win = 0;
                        Console.WriteLine("You have lost!");
                        return;
                    }
                    Console.WriteLine($"You've won {win} dollars!");

                }

            }
            else
            {
                Console.WriteLine("You are not allowed to play!");
            }
        }
    }
}
