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
        Order order;
        public Order Order
        {
            set => order = value;
        }

        UserControlMyOrder userControlMyOrder = new UserControlMyOrder();
        UserControlMyOrders userControlMyOrders = new UserControlMyOrders();
        public  UserControlMy_OrderList()
        {
            InitializeComponent();
        }
        public void SetLabelOrder(string takipno,string Date,string total)
        {
            lblOrderNo.Text = takipno;
            lblDate.Text = Date;
            lblTotalPrice.Text = total;
        }
        private void btnViewDetails_Click(object sender, EventArgs e)
        {

            userControlMyOrders.flowLayoutPanelOrderDetails.Controls.Add(userControlMyOrder);

            //SqlCommand command = new SqlCommand("select ", Database.CreateSingle().SqlConnection);

            //userControlMyOrder.SetLabelOrders()
        }
    }
}
