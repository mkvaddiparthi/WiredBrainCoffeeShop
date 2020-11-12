using CoffeeShopBusinessObjects;
using System;

namespace WiredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wire Brained Coffee Shop - For Asia region!");

            Console.WriteLine("Type 'help' to list all available commands !");

            var coffeeShopProvider = new CoffeeBusiness();

            while (true)
            {
                var line = Console.ReadLine();

                if (string.Equals(line, "help", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> available coffee shop commands");
                    foreach (var coffeshop in coffeeShopProvider.LoadCoffeeShops())
                    {
                        Console.WriteLine($"> " + coffeshop.Location);
                    }
                }
            }
        }        
    }
}
