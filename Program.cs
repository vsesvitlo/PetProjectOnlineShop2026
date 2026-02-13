namespace PetProjectOnlineShop2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductList listOfProducts = new ProductList();
            Product bread = new Product("00001", "Fresh Bread", "Nice bread...", 77);
            Product milk = new Product("00002", "Fresh Milk", "fresh milk...", 24);
            Product cheese = new Product("00003", "Fresh Cheese", "The farmer cheese...", 147);
            Product water = new Product("00004", "Mineral water", "The water from...", 14);
            Product candies = new Product("00005", "Natural candies", "Frytty-tutty candies...", 55);
            Product yogurt= new Product("00006", "Fresh yogurt", "Fresh milk...", 16);
            Client client = new Client("Prague", "Hlavni", "227", new DateOnly(1991, 5, 15), "Jan", "Buchta", "09cjfen", null, null, "997432");
            Cart cart = new Cart(DateTime.Now, new TimeSpan(0, 12, 6, 76), client, "");
            ShopAssistant shopAssistant = new ShopAssistant("Hanna", "Braun", "0jubt", cart, null, "A00001");

            listOfProducts.AddProductToProductList(bread, 16);
            listOfProducts.AddProductToProductList(milk, 5);
            listOfProducts.AddProductToProductList(cheese, 13);
            listOfProducts.AddProductToProductList(water, 33);
            listOfProducts.AddProductToProductList(candies, 14);
            listOfProducts.AddProductToProductList(yogurt, 25);

           
            foreach (KeyValuePair<Product, double> item in listOfProducts.productData)
            {
                //Console.WriteLine($"Product: {item.Key.title}, quantity:{item.Value} ");
            }
            
            /* decimal res = 0;
             for (int i = 1; i <= 1000000; i++)
             {
                 res += 0.000001m;
                // Console.WriteLine(res);
             }

             Console.WriteLine(res);*/


            // CalculationPriceList(ProductList productList)
            listOfProducts.AddProductToProductList(bread, 6);
            listOfProducts.AddProductToProductList(bread, 4);
            Console.WriteLine(listOfProducts.productData[bread]);
            // bread.AddQuantity();
            //Console.WriteLine(listOfProducts.CalculationQuantityPerProduct(bread);

            // bread.AddQuantity();
            // Console.WriteLine(bread.CalculationPrice());

            cart.AddProduct(listOfProducts, milk, 2);
            cart.AddProduct(listOfProducts, bread, 100);
            cart.CalculationSum();
            Console.WriteLine(cart.CalculationSum());
            Console.WriteLine(listOfProducts.productData[bread]);
            Console.WriteLine(listOfProducts.productData[milk]);
           ///// Console.WriteLine(cart.)
        }
    }
}
