using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnlineBookStore
{
    public partial class UserControlMy_OrderList : UserControl
    {
        UserControlMyOrders userControlMyOrders = UserControlMyOrders.CreateUserControlMyORders();
        public UserControlMy_OrderList()
        {
            InitializeComponent();
        }
        public void SetLabelOrder(string takipno, string Date, string total)
        {
            lblOrderNo.Text = takipno;
            lblDate.Text = Date;
            lblTotalPrice.Text = total;
        }
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            foreach (var item in userControlMyOrders.flowLayoutPanelOrderDetails.Controls.OfType<UserControlMyOrder>())
            {
                item.Visible = false;
            }
            userControlMyOrders.CreateMyOrders(lblOrderNo.Text);
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            ShoppingCart.CreateShoppingCart().CancelOrder(int.Parse(lblOrderNo.Text));
            userControlMyOrders.flowLayoutPanelOrders.Controls.Remove(this);
        }
    }
}
