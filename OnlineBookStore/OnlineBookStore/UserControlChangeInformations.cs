using System.Windows.Forms;

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
    }
}