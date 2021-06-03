using System.Windows.Forms;
using System.Data.SqlClient;
namespace OnlineBookStore
{
    public partial class UserControlChangeInformations : UserControl
    {
        private Customer customer = Customer.CreateCustomer();

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
        }

        private void btnUpdateImage_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxCustomer.ImageLocation = openFileDialog1.FileName;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Database.CreateSingle().Sqlconnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Customer SET ImagePath=@path where username=@username", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@path", openFileDialog1.FileName);
            command.Parameters.AddWithValue("@username", Customer.CreateCustomer().userInfo.Username);

            command.ExecuteNonQuery();
            Database.CreateSingle().Sqlconnection.Close();
            MessageBox.Show("Fotoğraf eklendi");
        }
    }
}