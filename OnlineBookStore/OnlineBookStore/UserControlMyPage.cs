using System;
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