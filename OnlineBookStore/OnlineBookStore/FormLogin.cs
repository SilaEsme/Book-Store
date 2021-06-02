using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class FormLogin : Form
    {
        private Customer customer = Customer.CreateCustomer();
        private FormMainPage main;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool flag = false;
            bool flag2 = false;
            HashCriptology hashCriptology = new HashCriptology();
            string sifre = txtPassword.Text;
            hashCriptology.MD5Sifrele(ref sifre);
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand command = new SqlCommand("SELECT * FROM CUSTOMER", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (dr.GetString(4) == txtUsername.Text)
                {
                    if (dr.GetString(5) == sifre) //hashli
                    {
                        customer.Name = dr.GetString(0);
                        customer.Surname = dr.GetString(1);
                        customer.Adress = dr.GetString(2);
                        customer.Email = dr.GetString(3);
                        customer.userInfo.Username = dr.GetString(4);
                        customer.userInfo.Password = dr.GetString(5);

                        flag = true;
                        break;
                    }
                }
            }
            Database.CreateSingle().Sqlconnection.Close();
            if (flag == false)
                MessageBox.Show("Your password or username is not correct. Please check your informations.", "Opppppps");
            else
            {
                main = new FormMainPage();
                main.Show();
                this.Hide();
            }
        }

        private void label_signup_Click(object sender, EventArgs e)
        {
            FormSignUp form = new FormSignUp();
            form.Show();
            this.Hide();
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}