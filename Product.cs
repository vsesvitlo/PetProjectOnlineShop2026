using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjectOnlineShop2026
{
    public class Product
    {
        protected string id;
        public string title;
        public string description;
        public decimal price;
        public double quantity;

        public Product(string id, string title, string description, decimal price, double quantity)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }
        public void AddQuantity(){
            quantity += 1;
        }
        public double GetQuantity()
        {
            return quantity;
        }
        public decimal CalculationPrice(){
            decimal result = price * (decimal)quantity;
            return result;
        }
    }
}
