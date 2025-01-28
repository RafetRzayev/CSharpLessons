using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagment
{
    internal class User
    {
        public User()
        {
            
        }
        public User(string username, string password, bool isSeller, int sellerId, int customerId)
        {
            Username = username;
            Password = password;
            IsSeller = isSeller;
            SellerId = sellerId;
            CustomerId = customerId;
        }

        public string Username {  get; set; }
        public string Password { get; set; }
        public bool IsSeller { get; set; }
        public int SellerId {  get; set; }
        public int CustomerId {  get; set; }
        //public int ReferencedPersonId {  get; set; }
    }
}
