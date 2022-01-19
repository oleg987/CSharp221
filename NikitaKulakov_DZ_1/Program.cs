using System;

namespace CSharp221NikitaKulakov_DZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 (UserInformation) \n");

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine().Trim(' ');
            Console.WriteLine("Enter your surname:");
            string surname = Console.ReadLine().Trim(' ');
            Console.WriteLine("Enter your middle name:");
            string middleName = Console.ReadLine().Trim(' ');

            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();
            float floatAge = float.Parse(age.Replace(".", ","));

            Console.WriteLine("Enter your country:");
            string country = Console.ReadLine().Trim(' ');
            Console.WriteLine("Enter your city:");
            string city = Console.ReadLine().Trim(' ');
            Console.WriteLine("Enter your street:");
            string street = Console.ReadLine().Trim(' ');
            Console.WriteLine("Enter your home number:");
            string homeNumber = Console.ReadLine().Replace(" ", "");
            Console.WriteLine("Enter your apartment number:");
            string apartamentNumber = Console.ReadLine();
            int intApartamentNumber = int.Parse(apartamentNumber);

            Console.WriteLine("Enter your phone number:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter your weight(kg):");
            string weight = Console.ReadLine();
            float floatWeight = float.Parse(weight.Replace(".", ","));
            Console.WriteLine("Enter your height(cm):");
            string height = Console.ReadLine();
            float floatHeight = float.Parse(height.Replace(".", ","));

            Console.Clear();
            Console.WriteLine("Full name: " + name + " " + surname + " " + middleName 
                + "\n Age: " + floatAge + " years" 
                + "\n Country: " + country 
                + "\n City: " + city 
                + "\n adress: " + street + " street " + homeNumber + ", apartament " + intApartamentNumber
                + "\n Phone number: " + phoneNumber
                + "\n Weight: " + floatWeight + " kg"
                + "\n Height: " + floatHeight + " cm \n");

            Console.WriteLine("Task 2 (ProductInformation) \n");

            Console.WriteLine("Enter product name:");
            string productName = Console.ReadLine().Trim(' ');

            Console.WriteLine("Enter product amount:");
            string productAmount = Console.ReadLine();
            float floatProductAmount = float.Parse(productAmount.Replace(".", ","));

            Console.WriteLine("Enter units of measure:");
            string productUnitsOfMeasure = Console.ReadLine().Trim(' ').ToLower();

            Console.WriteLine("Enter product price(in hrivnas):");
            string productPrice = Console.ReadLine();
            float floatProductPrice = float.Parse(productPrice.Replace(".", ","));

            Console.Clear();
            Console.WriteLine("Product name: " + productName 
                + "\n Product amount: " + productAmount + " " + productUnitsOfMeasure
                + "\n Product price: " + productPrice + " UAH");
        }
    }
}
