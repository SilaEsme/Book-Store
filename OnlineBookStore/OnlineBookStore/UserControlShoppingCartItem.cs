﻿using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlShoppingCartItem : UserControl
    {
        private UserControlShoppingCart userControlShoppingCart = UserControlShoppingCart.CreateShoppingCart();

        public UserControlShoppingCartItem()
        {
            InitializeComponent();
        }

        public void SetLabel(string name, string price, string amount)
        {
            lblName.Text = name;
            lblPrice.Text = price;
            lblTotalAmount.Text = amount;

            price = lblPrice.Text.Replace('.', ',');
            lblTotalPrice.Text = (Double.Parse(price) * Int32.Parse(amount)).ToString();
            lblTotalPrice.Text = lblTotalPrice.Text.Replace(',', '.');
            lblPrice.Text = price;

            string producttype = "";
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand command = new SqlCommand("SELECT ProductType FROM dbo.ShoppingCart WHERE ProductName = @Productname", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@ProductName", lblName.Text);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                producttype = dr.GetString(0);
            }
            Database.CreateSingle().Sqlconnection.Close();

            if (producttype == "Book")
            {
                string imagename = "";
                var dirs = Directory.GetFiles(@"Book Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
                SqlCommand command2 = new SqlCommand("SELECT ImagePath FROM dbo.Books WHERE name = @name", Database.CreateSingle().Sqlconnection);
                command2.Parameters.AddWithValue("@name", lblName.Text);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr2 = command2.ExecuteReader();

                while (dr2.Read())
                {
                    imagename = dr2.GetString(0);
                }
                Database.CreateSingle().Sqlconnection.Close();

                foreach (var item in dirs)
                {
                    if (Path.GetFileName(item) == imagename)
                    {
                        pictureBox_product.Image = new Bitmap(item);
                    }
                }
            }
            else if (producttype == "Magazine")
            {
                string imagename = "";
                var dirs = Directory.GetFiles(@"Magazine Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
                SqlCommand command3 = new SqlCommand("SELECT ImagePath FROM dbo.Magazines WHERE name = @name", Database.CreateSingle().Sqlconnection);
                command3.Parameters.AddWithValue("@name", lblName.Text);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr3 = command3.ExecuteReader();

                while (dr3.Read())
                {
                    imagename = dr3.GetString(0);
                }
                Database.CreateSingle().Sqlconnection.Close();

                foreach (var item in dirs)
                {
                    if (Path.GetFileName(item) == imagename)
                    {
                        pictureBox_product.Image = new Bitmap(item);
                    }
                }
            }
            else if (producttype == "MusicCD")
            {
                string imagename = "";
                var dirs = Directory.GetFiles(@"MusicCD Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
                SqlCommand command4 = new SqlCommand("SELECT ImagePath FROM dbo.Music_CDs WHERE name = @name", Database.CreateSingle().Sqlconnection);
                command4.Parameters.AddWithValue("@name", lblName.Text);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr4 = command4.ExecuteReader();

                while (dr4.Read())
                {
                    imagename = dr4.GetString(0);
                }
                Database.CreateSingle().Sqlconnection.Close();

                foreach (var item in dirs)
                {
                    if (Path.GetFileName(item) == imagename)
                    {
                        pictureBox_product.Image = new Bitmap(item);
                    }
                }
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update dbo.shoppingcart set Amount=@amount WHERE Productname = @name and username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@name", lblName.Text);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            int amount = Int32.Parse(lblTotalAmount.Text) + 1;
            lblTotalAmount.Text = amount.ToString();
            command.Parameters.AddWithValue("@amount", amount.ToString());

            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();

            int TempAmount = 0;
            double TempPrice = 0;
            TempAmount = Convert.ToInt32(userControlShoppingCart.GetLabelAmount());
            TempAmount++;
            userControlShoppingCart.SetLabelAmount(TempAmount.ToString());

            TempPrice = Double.Parse(userControlShoppingCart.GetLabelPrice());
            TempPrice += Double.Parse(this.lblPrice.Text.Replace('.', ','));
            userControlShoppingCart.SetLabelPrice(TempPrice.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int TempAmount = 0;
            double TempPrice = 0;
            TempAmount = Convert.ToInt32(userControlShoppingCart.GetLabelAmount());
            TempAmount -= Int32.Parse(this.lblTotalAmount.Text);
            userControlShoppingCart.SetLabelAmount(TempAmount.ToString());

            TempPrice = Double.Parse(userControlShoppingCart.GetLabelPrice());
            TempPrice -= Double.Parse(this.lblPrice.Text.Replace('.', ',')) * Int32.Parse(lblTotalAmount.Text);
            userControlShoppingCart.SetLabelPrice(TempPrice.ToString());

            this.Visible = false;
            userControlShoppingCart.flowLayoutPanelProducts.Controls.Remove(this);

            SqlCommand command = new SqlCommand("delete from dbo.shoppingcart WHERE Productname = @name and username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@name", lblName.Text);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            Database.CreateSingle().Sqlconnection.Open();
            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
        }

        private void btnDecrase_Click(object sender, EventArgs e)
        {
            if (lblTotalAmount.Text == "1")
            {
                btnDelete_Click(sender, e);
            }
            else
            {
                SqlCommand command = new SqlCommand("update dbo.shoppingcart set Amount=@amount WHERE Productname = @name and username=@username", Database.CreateSingle().Sqlconnection);
                command.Parameters.AddWithValue("@name", lblName.Text);
                command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);

                int TempAmount = 0;
                double TempPrice = 0;
                int amount = Int32.Parse(lblTotalAmount.Text) - 1;
                lblTotalAmount.Text = amount.ToString();
                TempAmount = Convert.ToInt32(userControlShoppingCart.GetLabelAmount());
                TempAmount--;
                userControlShoppingCart.SetLabelAmount(TempAmount.ToString());

                TempPrice = Double.Parse(userControlShoppingCart.GetLabelPrice());
                TempPrice -= Double.Parse(this.lblPrice.Text.Replace('.', ','));
                userControlShoppingCart.SetLabelPrice(TempPrice.ToString());
                command.Parameters.AddWithValue("@amount", amount.ToString());

                Database.CreateSingle().Sqlconnection.Open();
                command.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();
            }
        }
    }
}