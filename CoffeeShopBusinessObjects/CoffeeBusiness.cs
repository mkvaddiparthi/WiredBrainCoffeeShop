using System.Collections.Generic;

namespace CoffeeShopBusinessObjects
{
    public class CoffeeBusiness
    {
        public CoffeeBusiness()
        {

        }

        public IEnumerable<CoffeeModel> LoadCoffeeShops()
        {
            yield return new CoffeeModel() { Location = "Manchester", StockInShop = 100 };

            yield return new CoffeeModel() { Location = "London", StockInShop = 200 };

            yield return new CoffeeModel() { Location = "Stockport", StockInShop = 300 };

        }
    }
}
