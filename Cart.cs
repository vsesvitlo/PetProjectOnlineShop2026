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
       

        public void AddProduct(Product product)
        {
           
            order.Add(product, product.quantity);
        }

        public double CalculationSum()
        {
            double result = 0;
            foreach (KeyValuePair<Product, double> item in order ) {

                result += item.Key.price * item.Value;
            }
            return result;
        }
    }
}
