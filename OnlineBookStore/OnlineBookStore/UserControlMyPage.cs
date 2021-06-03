using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMyPage : UserControl
    {
        private Customer customer = Customer.CreateCustomer();
        private UserControlProductDetails userControlProductDetails = UserControlProductDetails.CreateProductDetails();
        private UserControlMusicCDDetail userControlMusicCDDetail = UserControlMusicCDDetail.CreateMusicCDDeatils();
        private UserControlMagazineDetails userControlMagazineDetails = UserControlMagazineDetails.CreateMagazineDetails();

        public UserControlMyPage()
        {
            InitializeComponent();
        }

        public void SetLabelMyPage()
        {
            lblName.Text = customer.Name;
            lblSurname.Text = customer.Surname;
            lblEMail.Text = customer.Email;
            lblAddress.Text = customer.Adress;
            lblUsername.Text = customer.userInfo.Username;
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

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            FormMainPage.Instance()._UserControlBooks.Visible = false;
            FormMainPage.Instance()._UserControlMagazines.Visible = false;
            FormMainPage.Instance()._UserControlMusicCDs.Visible = false;
            FormMainPage.Instance()._UserControlMyPage.Visible = false;
            FormMainPage.Instance()._UserControlShoppingCart.Visible = false;

            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;

            FormMainPage.Instance()._UserControlChangeInformations.Visible = true;
            FormMainPage.Instance()._UserControlChangeInformations.SetTextBoxInfo();
            FormMainPage.Instance().panelProductDisplay.Controls.Add(FormMainPage.Instance()._UserControlChangeInformations);
        }
    }
}