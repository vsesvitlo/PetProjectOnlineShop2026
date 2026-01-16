using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOnlineShop
{
    public class ShopAssistant : User
    {
        public ShopAssistant(string name, string surname, string password, Cart cartNow, Cart[] cartHistory, string idNumber) : base(name, surname, password, cartNow, cartHistory, idNumber)
        {
        }
    }
}
