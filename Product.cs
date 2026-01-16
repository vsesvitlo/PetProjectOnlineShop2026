using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOnlineShop
{
    public class Product
    {
        protected string id;
        public string title;
        public string description;
        public double price;

        public Product(string id, string title, string description, double price)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.price = price;
        }
    }
}
