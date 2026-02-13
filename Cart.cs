using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjectOnlineShop2026
{
    public class Cart
    {
        public DateTime timeOrder;
        public TimeSpan timeDelivery;
        public Client user;
        public string commentsCurrier;
        public Dictionary<Product, double> order;

        public Cart(DateTime timeOrder, TimeSpan timeDelivery, Client user, string commentsCurrier)
        {
            this.timeOrder = timeOrder;
            this.timeDelivery = timeDelivery;
            this.user = user;
            this.commentsCurrier = commentsCurrier;
            this.order = new Dictionary<Product, double>();
        }
       

        public void AddProduct(ProductList productList, Product product, int quantityClicks)
        {
           
            order.Add(product, quantityClicks);
           double rests = productList.GetQuantity(product);
            double quantityClicksNew = Convert.ToDouble(quantityClicks);
            if (quantityClicks > rests) {
               // Console.WriteLine($"Choose the less quantity, maximum {rests} of {product.title}");
                quantityClicksNew = rests;
            }
            else
            {
                productList.RemoveProductFromProductList(product, quantityClicks);
            }

        }

        public double CalculationSum()
        {
            double result = 0;
            foreach (KeyValuePair<Product, double> item in order ) {

                result += Convert.ToDouble(item.Key.price) * item.Value;
            }
            return result;
        }
    }

}
