using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOnlineShop
{
    public class Admin : User
    {
        public ProductList listChanges;

        public Admin(ProductList listChanges, string name, string surname, string password, Cart cartNow, Cart[] cartHistory, string idNumber) : base(name, surname, password, cartNow, cartHistory, idNumber)
        {
            this.listChanges = listChanges;
        }
    }
}
