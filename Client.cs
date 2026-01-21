namespace PetProjectOnlineShop2026
{
    public class Client : User
    {
        public string addressCity;
        public string addressStreet;
        public string addressNumder;
        private DateOnly birthdayDate;

        public Client(string addressCity, string addressStreet, string addressNumder, DateOnly birthdayDate, string name, string surname, string password, Cart cartNow, Cart[] cartHistory, string idNumber) : base(name, surname, password, cartNow, cartHistory, idNumber)
        {
            this.addressCity = addressCity;
            this.addressStreet = addressStreet;
            this.addressNumder = addressNumder;
            this.birthdayDate = birthdayDate;
        }

    
        
    }
}