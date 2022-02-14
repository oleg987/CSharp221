//Artem Mochuliak
using System;

namespace hometask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 13");
            Console.Write("Enter currency rate: ");
            double currency_rate = double.Parse(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                double grivna = i * currency_rate;
                Console.WriteLine($"{i} dollar(s) is {grivna} grivna");
            }
            Console.WriteLine("Задание 15");
            for (int i = 1; i <= 10; i++)
            {
                int result = i * 7;
                Console.WriteLine($"{i}*7 = {result}");
            }
           
            Console.WriteLine("Задание 16");
            for (int i = 1; i <= 10; i++)
            {
                int result = i * 9;
                Console.WriteLine($"{i}*9 = {result}");
            }
            Console.WriteLine("Задание 22");

            for (double i = 0.1; i <= 0.9; i+=0.1)
            {
                double root = Math.Sqrt(i);
                Console.WriteLine($"Value of square root of {i} is {root}");
            }
            Console.WriteLine("Задание 6");
            for (double i = 0;i <= 100; i++)
            {
                double Fahrenheit = 9 * i / 5 + 32;
                Console.WriteLine($"{i} degrees in Celsius is {Fahrenheit} degrees in Fahrenheit");
            }
            Console.WriteLine("Задание 25");
            Console.Write("Enter price for 1 kg: ");
            double price_1_kg = double.Parse(Console.ReadLine());
            for (double i = 50; i <= 1000; i += 50)
            {
                
                double weight_in_kg = i / 1000;
                
                double price = weight_in_kg * price_1_kg;
                Console.WriteLine($"Price for {weight_in_kg} kg is {price}");
            }
            Console.WriteLine("Задание 10");
            for (double i = 1; i <= 10; i++)
            {
                double pound_in_gramm = 453;
                double pound_in_kg = pound_in_gramm / 1000;
                double kg = i * pound_in_kg;
                Console.WriteLine($"{i} pound(s) is {kg} kg");
            }
            Console.WriteLine("Задание 21");
            for (double i = 0.1; i <= 1.1; i+=0.1)
            {
                double result = Math.Sin(i);

                Console.WriteLine($"sin{i} = {result}");
            }
            Console.WriteLine("Задание 9");
            double price_for_1 = 20.4;
            for (double i = 2; i <=20; i++)
            {
                double price = i * price_for_1;
                Console.WriteLine($"Price for {i} piece is {price} griven");
            }
            Console.WriteLine("Задание 8");
            int a = 12345679;
            for (int i = 9; i <=81; i+=9)
            {
                int result = i * a;
                Console.WriteLine($"{i}*{a} = {result}");
            }
            Console.WriteLine("Задание 11");
            for (double i = 10; i <= 22; i++)
            {
                double inch_in_mm = 25.4;
                double inch_in_cm = inch_in_mm / 10;
                double cm = i * inch_in_cm;
                Console.WriteLine($"{i} inch(es) is {cm} cm");
            }
        }
    }
}
