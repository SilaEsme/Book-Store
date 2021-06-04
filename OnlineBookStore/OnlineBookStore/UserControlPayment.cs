using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlPayment : UserControl
    {
        Customer customer = Customer.CreateCustomer();
        private static UserControlPayment userControlPayment;

        public static UserControlPayment CreateUserControlPayment()
        {
            if (userControlPayment == null)
                userControlPayment = new UserControlPayment();
            return userControlPayment;

        }
        public UserControlPayment()
        {
            InitializeComponent();
        }

        private void UserControlPayment_Load(object sender, EventArgs e)
        {
            UserControlShoppingCart UserControlShoppingCart = UserControlShoppingCart.Instance();
            lblTotalProduct.Text = UserControlShoppingCart.GetLabelPrice();

            double temp = 11.40, temp2 = 0;
            temp2= Double.Parse(lblTotalProduct.Text) + temp;
            lblFinalTotal.Text = temp2.ToString();
        }

        private void btnPurchaseNow_Click(object sender, EventArgs e)
        {

        }

    }
}
