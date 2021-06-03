using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlShoppingCart : UserControl
    {
        private ShoppingCart shoppingCart = new ShoppingCart();
        public ShoppingCart ShoppingCart
        {
            get => shoppingCart;
        }

        private static UserControlShoppingCart userControlShoppingCart;
        public static UserControlShoppingCart Instance()
        {
            if (userControlShoppingCart == null)
                userControlShoppingCart = new UserControlShoppingCart();
            return userControlShoppingCart;
        }
        public UserControlShoppingCart()
        {
            InitializeComponent();
            userControlShoppingCart = this;
        }
        public void SetLabelAmount(string amount)
        {
            lblTotalAmount.Text = amount;
        }
        public void SetLabelPrice(string price)
        {
            lblTotalPrice.Text = price;
        }
        public string GetLabelAmount()
        {
            return lblTotalAmount.Text;
        }
        public string GetLabelPrice()
        {
            return lblTotalPrice.Text.Replace('.',',');
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            shoppingCart.ClearCart();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }
    }
}