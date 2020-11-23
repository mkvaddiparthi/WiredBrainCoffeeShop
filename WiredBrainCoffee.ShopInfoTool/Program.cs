using CoffeeShopBusinessObjects;
using System;
using System.Linq;

namespace WiredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wire Brained Coffee Shop - For Asia region!");

            Console.WriteLine("Type 'help' to list all available commands ! Press 'quit' to exit from the menu.");

            var coffeeShopProvider = new CoffeeBusiness();

            while (true)
            {
                var line = Console.ReadLine();

                if (string.Equals(line, "quit spacess added", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (string.Equals(line, "help spacess added", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> available coffee shop commands");
                    foreach (var coffeshop in coffeeShopProvider.LoadCoffeeShops())
                    {
                        Console.WriteLine($"> " + coffeshop.Location);
                    }
                }
                else
                {
                    var coffeeShop = coffeeShopProvider.LoadCoffeeShops().ToList().Where(w => w.Location.Equals(line, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

                    switch (coffeeShop.Location.ToLower())
                    {
                        case "london":
                            Console.WriteLine("The paper cups in London coffee shop are : " + coffeeShop.StockInShop.ToString());
                            break;
                        case "manchester":
                            Console.WriteLine("Manchester coffee shop having " + coffeeShop.StockInShop.ToString() + " number of paper coffee cups.");
                            break;
                        case "stockport":
                            Console.WriteLine("Stockport coffee shop cups : " + coffeeShop.StockInShop.ToString());
                            break;
                        case "others":
                            Console.WriteLine("invalid city code");
                            break;
                    }
                }
            }
        }
    }
}
