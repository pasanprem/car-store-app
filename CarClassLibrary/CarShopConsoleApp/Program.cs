using System;
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
                    case 1:
                        Console.WriteLine("You choose to add a new car to the inventory");
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


                }

                action = chooseAction();
            }

            
        }

        private static void printInventory(Store s)
        {
            foreach (Car c in s.CarList)
            {
                Console.WriteLine("Car: " + c);
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
