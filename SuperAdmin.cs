using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProjectOnlineShop2026
{
    public class SuperAdmin : Admin
    {
        private UsersDatabase listAdmins;

        public SuperAdmin(UsersDatabase listAdmins, ProductList listChanges, string name, string surname, string password, Cart cartNow, Cart[] cartHistory, string idNumber) : base(listChanges, name, surname, password, cartNow, cartHistory, idNumber)
      
         {
             this.listAdmins = listAdmins;
         }
    }
}
