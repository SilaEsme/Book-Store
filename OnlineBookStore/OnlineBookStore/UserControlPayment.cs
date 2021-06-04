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
    public partial class UserControlPayment : UserControl
    {
        ShoppingCart ShoppingCart = ShoppingCart.CreateShoppingCart();
        Customer customer = Customer.CreateCustomer();
        UserControlMyOrders userControlMyOrders = UserControlMyOrders.CreateUserControlMyORders();
        private static UserControlPayment userControlPayment;
        public bool flag = false, flag2 = false;
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


        }
        public void CalculateTotal()
        {
            UserControlShoppingCart UserControlShoppingCart = UserControlShoppingCart.Instance();
            lblTotalProduct.Text = UserControlShoppingCart.GetLabelPrice();
            double temp2 = 0;
            temp2 = Double.Parse(lblTotalProduct.Text) + Double.Parse(lblCargo.Text);
            lblFinalTotal.Text = temp2.ToString();

            lblTwo.Text = Math.Round ((Double.Parse(lblFinalTotal.Text) /2), 2).ToString();
            lblFour.Text = Math.Round((Double.Parse(lblFinalTotal.Text) /4), 2).ToString();
            lblFive.Text = Math.Round((Double.Parse(lblFinalTotal.Text) /5), 2).ToString();
            lblSix.Text = Math.Round((Double.Parse(lblFinalTotal.Text) /6), 2).ToString();

        }
       
        private void btnPurchaseNow_Click(object sender, EventArgs e)
        {
            flag =true;

            if (radioButtonYutici.Checked == false && radioButtonAras.Checked == false)
            {
                MessageBox.Show("Please Select a Cargo Company!", "Fail Order", MessageBoxButtons.OK);
            }          
            else
            {
                DateTime date = DateTime.Now;
                Random rand = new Random();
                int OrderNumber = rand.Next(10000, 999999);
                //CLASS - name price quantity total
                Order order = new Order(OrderNumber.ToString(),date.ToString());


                //SQL
                SqlCommand command = new SqlCommand("insert into orderlist (OrderNumber,OrderTime,OrderTotalPrice,username) values (@orderno,@ordertime,@orderTotalPrice,@username)", Database.CreateSingle().Sqlconnection);

                command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
                command.Parameters.AddWithValue("@orderno", OrderNumber.ToString());
                command.Parameters.AddWithValue("@OrderTime", date.ToString());
                command.Parameters.AddWithValue("@orderTotalPrice",lblFinalTotal.Text);

                Database.CreateSingle().Sqlconnection.Open();
                command.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();

                MessageBox.Show("Your Order has been Created!", "New Order", MessageBoxButtons.OK);
                ShoppingCart.ClearCart();
            }

        }

        private void radioButtonYutici_CheckedChanged(object sender, EventArgs e)
        {
            lblCargo.Text = "11,90";
            CalculateTotal();
        }

        private void radioButtonAras_CheckedChanged_1(object sender, EventArgs e)
        {
            lblCargo.Text = "8,50";
            CalculateTotal();
        }


        private void tabControlCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(tabControlCredit.SelectedTab==tabPageCash)
            {
                textBoxCreditNum.Text = "";
                textBoxNameCredit.Text = "";
                textBoxCVV.Text = "";
                comboBoxYear.Text = "";
                comboBoxMonth.Text = "";
            }
            else if (tabControlCredit.SelectedTab ==tabPageCreditCard)
            {
                textBoxCashBankNo.Text = "";
                textBoxCardNme.Text = "";
                textBoxCashCVV.Text = "";
                comboBoxCashMonth.Text = "";
                comboBoxCashYear.Text = "";
            }
          
        }
    }
}
