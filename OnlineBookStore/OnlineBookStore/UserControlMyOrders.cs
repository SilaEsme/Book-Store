using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMyOrders : UserControl
    {

        private static UserControlMyOrders userControlMyOrders;
        public static UserControlMyOrders CreateUserControlMyORders()
        {
            if (userControlMyOrders == null)
                userControlMyOrders = new UserControlMyOrders();
            return userControlMyOrders;
        }
        protected UserControlMyOrders()
        {
            InitializeComponent();
        }
        public void CreateMyOrders(string no)//ürün detayları
        {
            SqlCommand command = new SqlCommand("SELECT ProductName,price,amount,OrderNo FROM dbo.ShoppingCart where username=@username and OrderNo=@no", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            command.Parameters.AddWithValue("@no", no);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                UserControlMyOrder userControlMyOrder = new UserControlMyOrder();
                userControlMyOrder.SetLabelOrders(dr.GetString(0), dr.GetString(2), dr.GetString(1), no);
                flowLayoutPanelOrderDetails.Controls.Add(userControlMyOrder);
            }
            Database.CreateSingle().Sqlconnection.Close();
        }
        public bool CreateOrder()//order list
        {
            SqlCommand command = new SqlCommand("SELECT OrderNumber,OrderTime,OrderTotalPrice,username FROM dbo.OrderList where username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);

            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (!dr.Read())
            {
                Database.CreateSingle().Sqlconnection.Close();
                return false;
            }


            while (dr.Read())
            {
                UserControlMy_OrderList userControlMy_OrderList = new UserControlMy_OrderList();

                userControlMy_OrderList.SetLabelOrder(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                flowLayoutPanelOrders.Controls.Add(userControlMy_OrderList);
            }

            Database.CreateSingle().Sqlconnection.Close();
            return true;
        }
        public void DeleteOrders()
        {
            flowLayoutPanelOrders.Controls.Clear();
        }
    }
}
