using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMyOrder : UserControl
    {
        public UserControlMyOrder()
        {
            InitializeComponent();
        }
       
        public void SetLabelOrders(string name, string amount, string price)
        {
            Database database = Database.CreateSingle();
            database.GetConnection();

            lblName.Text = name;
            lblPrice.Text = price;
            lblTotalAmount.Text = amount;
            lblTotalPrice.Text = (Double.Parse(lblPrice.Text.Replace('.', ',')) * Double.Parse(lblTotalAmount.Text)).ToString();

        }
    }
}
