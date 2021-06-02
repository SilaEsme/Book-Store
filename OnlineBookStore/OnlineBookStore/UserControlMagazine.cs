using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMagazine : UserControl
    {
        UserControlMagazineDetails userControlMagazineDetails = UserControlMagazineDetails.CreateMagazineDetails();
        Magazine magazine = new Magazine();

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

            userControlMagazineDetails.SetMagazineInfo(magazine.Name, magazine.Issue, magazine.Price,
            magazine._TypeMagazine);
            FormMainPage.Instance().panelProductDisplay.Controls.Add(userControlMagazineDetails);

            userControlMagazineDetails.Visible = true;
        }
    }
}
