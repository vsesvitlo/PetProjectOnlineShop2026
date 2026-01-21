using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjectOnlineShop2026
{
    public class User
    {
    public string name;
    public string surname;
    protected string password;
    public Cart cartNow;
    public Cart[] cartHistory;
    private string idNumber;

        public User(string name, string surname, string password, Cart cartNow, Cart[] cartHistory, string idNumber)
        {
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.cartNow = cartNow;
            this.cartHistory = cartHistory;
            this.idNumber = idNumber;
        }

        public void AddProductCart(Product product)
        {
            cartNow.AddProduct(product);
        }
        public void AddCart(Cart cart)
        {

        }
        public void RemoveProductCart(Product product)
        {

        }
        public void RemoveCart(Cart cart) {
        }
        public bool Payment(bool responce)
        {
            return responce;
        }
        public bool ReceivingOrder(bool responce)
        {
            return responce;
        }
    }
}
