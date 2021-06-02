using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public class Customer
    {
        private static Customer customer;
        static int customerID;
        string name;
        string adress;
        string email;
        string surname;
        UserInfo UserInfo = new UserInfo();

        public static Customer CreateCustomer()
        {
            if (customer == null)
                customer = new Customer();
            return customer;
        }

        protected Customer()
        {

        }
        //public void SetUsernamePassword(string u,string p)
        //{
        //    userInfo.
        //}
        public UserInfo userInfo
        {
            get => UserInfo;
            set => UserInfo = value;
        }
        public int CustomerId
        {
            get => customerID;
            set => customerID = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Surname
        {
            get => surname;
            set => surname = value;
        }
        public string Adress
        {
            get => adress;
            set => adress = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public void PrintCustomerDetails()
        {

        }
        public void SaveCustomer()
        {

        }
        public void PrintCustomerPurchases()
        {

        }
    }
}
