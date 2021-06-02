using System;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlShoppingCartItem : UserControl
    {
        public UserControlShoppingCartItem()
        {
            InitializeComponent();
        }
        public void SetLabel(string name, string price, string amount)
        {
            lblName.Text = name;
            lblPrice.Text = price;
            lblTotalAmount.Text = amount;
            lblTotalPrice.Text = (Convert.ToDouble(price) * Convert.ToDouble(amount)).ToString();
        }
    }
}