using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjectOnlineShop2026
{
    public class ProductList
    {
        public Dictionary<Product, double> productData;

        public ProductList(Dictionary<Product, double> productData)
        {
            this.productData = productData;
        }

        public void AddProductToProductList(Product product, double quantity)
        {
           if (!productData.ContainsKey(product)){
                productData.Add(product, quantity);
            }
            productData[product] += quantity;

        }

        public void RemoveProductFromProductList(Product product, double quantity)
        {
            if (productData.ContainsKey(product))
            {
                productData[product] -= quantity;
            }
        }

        public decimal CalculationPriceList(ProductList productList)
        {
            decimal result = 0;
            foreach (KeyValuePair<Product, double> item in productData)
            {

                result += item.Key.price * (decimal) item.Value;
            }
            return result;
        }
    }
}
