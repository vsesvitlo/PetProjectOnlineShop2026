namespace PetProjectOnlineShop2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product bread = new Product("00001", "Fresh Bread", "Nice bread...", 77);
            Product milk = new Product("00002", "Fresh Milk", "fresh milk...", 24);
            Client client = new Client("Prague", "Hlavni", "227", new DateOnly(1991, 5, 15), "Jan", "Buchta", "09cjfen", null, null, "997432");
            Cart cart = new Cart(DateTime.Now, new TimeSpan(0, 12, 6, 76), client, "");

            cart.AddProduct(milk, 1);
            cart.AddProduct(bread, 1);
            cart.CalculationSum();
            Console.WriteLine("Hello, World!");
        }
    }
}
