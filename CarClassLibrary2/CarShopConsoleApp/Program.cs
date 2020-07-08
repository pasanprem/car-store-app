﻿using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using CarClassLibrary;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();

            Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("You chose " + action);

                switch(action)
                {
                    //add item to inventory
                    case 1:
                        Console.WriteLine("You chose to add a new car to the inventory");
                        string carMake = "";
                        string carModel = "";
                        decimal carPrice = 0;

                        Console.WriteLine("What is the car make? Ford, GM, Nissan, etc. ");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model? Corvette, Focus, etc. ");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the car price? ");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice);
                        s.CarList.Add(newCar);

                        printInventory(s);
                        break;

                    //add to cart
                    case 2:
                        Console.WriteLine("You chose to add a car to the shopping cart");
                        printInventory(s);
                        Console.WriteLine("Which item would you like to buy? (number)");
                        int carChosen = int.Parse(Console.ReadLine());

                        s.ShoppingList.Add(s.CarList[carChosen]);

                        printShoppingCart(s);

                        break;

                    //checkout
                    case 3:
                        printShoppingCart(s);
                        Console.WriteLine("The total cost of your items is : " + s.Checkout());

                        break;

                    default:
                        break;
                }

                action = chooseAction();
            }

            
        }

        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("Cars you have chosen to buy ");

            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine("Car # : " + i + " " + s.ShoppingList[i]);
            }
        }

        private static void printInventory(Store s)
        {
            for (int i = 0; i < s.CarList.Count; i++)
            {
                Console.WriteLine("Car # : " + i + " " + s.CarList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a enw car to inventory (2) add car to cart (3) checkout");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
