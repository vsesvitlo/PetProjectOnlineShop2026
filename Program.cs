namespace PetProjectOnlineShop2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product bread = new Product("00001", "Fresh Bread", "Nice bread...", 77, 1);
            Product milk = new Product("00002", "Fresh Milk", "fresh milk...", 24, 1);
            Product cheese = new Product("00003", "Fresh Cheese", "The farmer cheese...", 147, 1);
            Product water = new Product("00004", "Mineral water", "The water from...", 14, 1);
            Product candies = new Product("00005", "Natural candies", "Frytty-tutty candies...", 55, 1);
            Product yogurt= new Product("00006", "Fresh yogurt", "Fresh milk...", 16, 1);

            decimal res = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                res += 0.000001m;
               // Console.WriteLine(res);
            }

            Console.WriteLine(res);

            Client client = new Client("Prague", "Hlavni", "227", new DateOnly(1991, 5, 15), "Jan", "Buchta", "09cjfen", null, null, "997432");
            Cart cart = new Cart(DateTime.Now, new TimeSpan(0, 12, 6, 76), client, "");
           // CalculationPriceList(ProductList productList)
            bread.AddQuantity();
            bread.AddQuantity();
            bread.AddQuantity();
            bread.GetQuantity();
            bread.AddQuantity();
            Console.WriteLine(bread.CalculationPrice());
            cart.AddProduct(milk);
            cart.AddProduct(bread);
            cart.CalculationSum();
            Console.WriteLine(cart.CalculationSum());
        }
    }
}
