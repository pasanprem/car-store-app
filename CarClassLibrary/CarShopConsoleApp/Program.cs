using System;
using CarClassLibrary;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Nissan", "Sentra", 7322);
            Car d = new Car("Ford", "Mustang", 9200);

            Console.WriteLine("Car c is as follows: " + c.Make + " " + c.Model + " " + c.Price);
            Console.WriteLine("Car d is as follows: " + d.Make + " " + d.Model + " " + d.Price);

            Store s = new Store();

            s.ShoppingList.Add(c);
            s.ShoppingList.Add(d);

            decimal total = s.Checkout();

            Console.WriteLine("Store Value is " + total);

            Console.ReadLine();
        }
    }
}
