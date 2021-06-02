using System;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMagazine : UserControl
    {
        private UserControlMagazineDetails userControlMagazineDetails = UserControlMagazineDetails.CreateMagazineDetails();
        private Magazine magazine = new Magazine();

        public Magazine _Magazine
        {
            get => magazine;
            set => magazine = value;
        }

        public UserControlMagazine()
        {
            InitializeComponent();
        }

        public void SetLabelMagazine(string name, string Price)//küçük booklar için
        {
            lblName.Text = name;
            lblPrice.Text = Price;
        }

        private void btnReadMore_Click(object sender, EventArgs e)
        {
            FormMainPage.Instance()._UserControlBooks.Visible = false;
            FormMainPage.Instance()._UserControlMusicCDs.Visible = false;
            FormMainPage.Instance()._UserControlMagazines.Visible = false;
            FormMainPage.Instance()._UserControlShoppingCart.Visible = false;

            userControlMagazineDetails.SetMagazineInfo(magazine.ProductName, magazine.Issue, magazine.ProductPrice,
            magazine._TypeMagazine);
            FormMainPage.Instance().panelProductDisplay.Controls.Add(userControlMagazineDetails);

            userControlMagazineDetails.Visible = true;
        }
    }
}