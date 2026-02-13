using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjectOnlineShop2026
{
    public class ShopAssistant : User
    {
        public ShopAssistant(string name, string surname, string password, Cart cartNow, Cart[] cartHistory, string idNumber) : base(name, surname, password, cartNow, cartHistory, idNumber)
        {

        }

        public void AddProductToProductList(Product product, double quantity, Dictionary<Product, double> productData)
        {
            if (!productData.ContainsKey(product))
            {
                productData.Add(product, quantity);
            }
            else
            {
                productData[product] += quantity;
            }
        }

        public void RemoveProductFromProductList(Product product, double quantity, Dictionary<Product, double> productData)
        {
            if (productData.ContainsKey(product))
            {
                productData[product] -= quantity;
            }
        }

    }

}
