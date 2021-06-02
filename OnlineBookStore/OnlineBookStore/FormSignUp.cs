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
    public partial class FormSignUp : Form
    {
        public SqlCommand Command { get; private set; }

        public FormSignUp()
        {
            InitializeComponent();
        }

     

        private void btn_signup_Click(object sender, EventArgs e)
        {
            bool flag = false;
            HashCriptology hashCriptology = new HashCriptology();
            string sifre = txtPassword.Text;
            hashCriptology.MD5Sifrele(ref sifre);
            Database database = Database.CreateSingle();
            database.GetConnection();

            SqlCommand command2 = new SqlCommand("SELECT Username FROM CUSTOMER", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command2.ExecuteReader();

            if (txtPassword.Text != "" && txtUsername.Text != "" && txtAddress.Text != "" && 
                txtName.Text != "" && txteMail.Text != "" && txtSurname.Text != "")
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    string command = "INSERT INTO Customer(Name, Surname, Adress, EMail, Username, Password) VALUES(@Name, @Surname, @Adress, @EMail, @Username, @Password)";
                    Command = new SqlCommand(command, Database.CreateSingle().Sqlconnection);
                    Command.Parameters.AddWithValue("@Name", txtName.Text);
                    Command.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    Command.Parameters.AddWithValue("@Adress", txtAddress.Text);
                    Command.Parameters.AddWithValue("@EMail", txteMail.Text);
                    Command.Parameters.AddWithValue("@Password", sifre);
                    Command.Parameters.AddWithValue("@Username", txtUsername.Text);

                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtUsername.Text)
                        {
                            MessageBox.Show("Your username is already taken!", "Invalid");
                            flag = true;
                            break;
                        }
                    }
                    Database.CreateSingle().Sqlconnection.Close();
                    if (flag == false)
                    {
                        Database.CreateSingle().Sqlconnection.Open();
                        Command.ExecuteNonQuery();
                        Database.CreateSingle().Sqlconnection.Close();
                        FormLogin formLogin = new FormLogin();
                        formLogin.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Your password and confirm password doesn't match!", "Invalid");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the blanks!", "Invalid");
            }

        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
