using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlProductDetails : UserControl
    {
        private static UserControlProductDetails userControlProductDetails;

        public static UserControlProductDetails CreateProductDetails()
        {
            if (userControlProductDetails == null)
                userControlProductDetails = new UserControlProductDetails();
            return userControlProductDetails;
        }

        public UserControlProductDetails()
        {
            InitializeComponent();
        }

        public void SetBookInfo(string name, string author, string publisher,
        string page, string ISBN, string price, string cover, _type type)
        {
            lblName.Text = name;
            lblAuthor.Text = author;
            lblPublisher.Text = publisher;
            lblPage.Text = page;
            lblISBN.Text = ISBN;
            lblPrice.Text = price;
            lblCover.Text = cover;
            lblType.Text = type.ToString();
        }
       
        private void btn_AddtoCart_Click(object sender, System.EventArgs e)
        {
            Database.CreateSingle().Sqlconnection.Open();

            int SqlAmount = 0;
            bool read;
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand amount = new SqlCommand("SELECT Amount from ShoppingCart where ProductName='" + lblName.Text + "' and Username='" + Customer.CreateCustomer().userInfo.Username + "'", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = amount.ExecuteReader();
            read = dr.Read();
            Database.CreateSingle().Sqlconnection.Close();

            if (read == false)//data yoktur yeni eklenecek
            {
                SqlCommand command = new SqlCommand("INSERT INTO dbo.ShoppingCart VALUES (@name,@price,@amount,@username)", Database.CreateSingle().Sqlconnection);
                command.Parameters.AddWithValue("@name", lblName.Text);
                command.Parameters.AddWithValue("@price", lblPrice.Text);
                command.Parameters.AddWithValue("@amount", "1");
                command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
                Database.CreateSingle().Sqlconnection.Open();
                command.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();

            }
            else if (read == true)//data vardır amount arttırılcak
            {
                SqlCommand amount2 = new SqlCommand("SELECT Amount from ShoppingCart where ProductName='" + lblName.Text + "' and Username='" + Customer.CreateCustomer().userInfo.Username + "'", Database.CreateSingle().Sqlconnection);
                Database.CreateSingle().Sqlconnection.Open();
                SqlDataReader dr2 = amount2.ExecuteReader();

                while (dr2.Read())
                {
                    SqlAmount = Int32.Parse(dr2.GetString(0));
                }

                Database.CreateSingle().Sqlconnection.Close();
                SqlAmount++;
                string command2 = "UPDATE ShoppingCart SET Amount=@Amount where ProductName='" + lblName.Text + "' and Username='" + Customer.CreateCustomer().userInfo.Username + "'";
                SqlCommand Command2 = new SqlCommand(command2, Database.CreateSingle().Sqlconnection);
                Command2.Parameters.AddWithValue("@Amount", SqlAmount.ToString());
                Database.CreateSingle().Sqlconnection.Open();
                Command2.ExecuteNonQuery();
                Database.CreateSingle().Sqlconnection.Close();
            }
            labelAddInfo.Text = "Product is added to cart successfully";
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, d) =>
            {
                labelAddInfo.Text="";
                t.Stop();
            };
            t.Start();
        }
    }
}