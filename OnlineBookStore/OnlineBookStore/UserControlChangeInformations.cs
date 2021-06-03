using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlChangeInformations : UserControl
    {
        private Customer customer = Customer.CreateCustomer();
        private Byte[] _bytesOfImage;

        public UserControlChangeInformations()
        {
            InitializeComponent();
        }

        public void SetTextBoxInfo()
        {
            txtaddress.Text = customer.Adress;
            txtemail.Text = customer.Email;
            txtname.Text = customer.Name;
            txtsurname.Text = customer.Surname;
            txtusername.Text = customer.userInfo.Username;
            string imagename = "";
            var dirs = Directory.GetFiles(@"Profile Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
            SqlCommand command = new SqlCommand("SELECT ImagePath FROM dbo.Customer WHERE username = @username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                imagename = dr.GetString(0);
            }
            Database.CreateSingle().Sqlconnection.Close();

            foreach (var item in dirs)
            {
                if (Path.GetFileName(item) == imagename)
                {
                    pictureBoxCustomer.Image = new Bitmap(item);
                }
            }
        }

        public Byte[] BytesOfImage
        {
            get { return _bytesOfImage; }
            set { _bytesOfImage = value; }
        }

        private void btnUpdateImage_Click(object sender, System.EventArgs e)
        {
            //save code

            DialogResult dgResult = openFileDialog1.ShowDialog();
            pictureBoxCustomer.ImageLocation = openFileDialog1.FileName;
            if (dgResult == DialogResult.OK)
            {
                string filename = Path.GetFileName(openFileDialog1.FileName);
                string destinationPath = Path.Combine(Environment.CurrentDirectory, @"Profile Images", filename);

                if (openFileDialog1.FileName != destinationPath)
                    System.IO.File.Copy(openFileDialog1.FileName, destinationPath);
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            string filename = Path.GetFileName(openFileDialog1.FileName);
            Database.CreateSingle().Sqlconnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Customer SET ImagePath=@filename where username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@filename", filename);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);

            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
            MessageBox.Show("The profile image is added.");
        }
    }
}