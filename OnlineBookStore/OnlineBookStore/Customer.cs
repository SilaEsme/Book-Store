namespace OnlineBookStore
{
    public class Customer
    {
        private static Customer customer;
        private static int customerID;
        private string name;
        private string adress;
        private string email;
        private string surname;
        private UserInfo UserInfo = new UserInfo();

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