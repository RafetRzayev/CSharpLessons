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
        public User(string username, string password, UserType userType, int sellerId, int customerId)
        {
            Username = username;
            Password = password;
            UserType = userType;
            SellerId = sellerId;
            CustomerId = customerId;
        }

        public string Username {  get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public int SellerId {  get; set; }
        public int CustomerId {  get; set; }
        //public int ReferencedPersonId {  get; set; }
    }

    enum UserType
    {
        Admin,
        Seller,
        Customer
    }
}
