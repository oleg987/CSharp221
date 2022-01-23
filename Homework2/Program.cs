using System;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool canContinue = true;
            int intRate = 0;

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();
            int intAge = Convert.ToInt32(age);

            if (intAge < 18 && intAge >= 0)
            {
                Console.WriteLine("People under 18 are not allowed to play.");
                canContinue = false;
            }
            else if (intAge < 0)
            {
                Console.WriteLine("Your age can't be negative.");
                canContinue = false;
            }

            if (canContinue == true)
            {
                Console.WriteLine("Enter your rate (5$-100$):");
                string rate = Console.ReadLine();
                intRate = Convert.ToInt32(rate);

                if (intRate < 5 || intRate > 100)
                {
                    Console.WriteLine("Your rate must be less than $100 and above $5");
                    canContinue = false;
                }
            }

            if (canContinue == true)
            {
                float prize = 0;

                Random rnd = new Random();
                int firstNumber = rnd.Next(1, 10);
                int secondNumber = rnd.Next(1, 10);
                int thirdNumber = rnd.Next(1, 10);

                int finalNumber = (firstNumber * 100) + (secondNumber * 10) + thirdNumber;

                Console.WriteLine("\n" + finalNumber);

                if (firstNumber == secondNumber && secondNumber == thirdNumber)
                {
                    if (firstNumber != 9 && firstNumber != 7)
                    {
                        prize = intRate * firstNumber * 10f * 1.5f;
                    }
                    else if (firstNumber == 9)
                    {
                        prize = intRate * firstNumber * 10f * 1.35f;
                    }
                    else if (firstNumber == 7)
                    {
                        prize = intRate * firstNumber * 10f * 1.6f;
                    }

                    Console.WriteLine("You win! prize: " + prize + "$");
                }
                else if (firstNumber == secondNumber && secondNumber != thirdNumber)
                {
                    if (firstNumber != 9 && firstNumber != 7)
                    {
                        prize = intRate * firstNumber * 1.5f;
                    }
                    else if (firstNumber == 9)
                    {
                        prize = intRate * firstNumber * 1.35f;
                    }
                    else if (firstNumber == 7)
                    {
                        prize = intRate * firstNumber * 1.6f;
                    }

                    Console.WriteLine("You win! prize: " + prize + "$");
                }
                else
                {
                    Console.WriteLine("You loose!");
                }
            }
        }
    }
}
