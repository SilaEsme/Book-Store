using System;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class FormMainPage : Form
    {
        private static FormMainPage mainPage;

        private UserControlBooks userControlBooks;
        private UserControlMusicCDs userControlMusicCDs;
        private UserControlMagazines UserControlMagazines;
        private UserControlShoppingCart userControlShoppingCart;

        private UserControlProductDetails userControlProductDetails;
        private UserControlMusicCDDetail userControlMusicCDDetail;
        private UserControlMagazineDetails userControlMagazineDetails;
        private UserControlChangeInformations userControlChangeInformations;
        private UserControlMyPage userControlMyPage;

        public UserControlBooks _UserControlBooks
        {
            get => userControlBooks;
            set => userControlBooks = value;
        }

        public UserControlMusicCDs _UserControlMusicCDs
        {
            get => userControlMusicCDs;
            set => userControlMusicCDs = value;
        }

        public UserControlMagazines _UserControlMagazines
        {
            get => UserControlMagazines;
            set => UserControlMagazines = value;
        }

        public UserControlShoppingCart _UserControlShoppingCart
        {
            get => userControlShoppingCart;
            set => userControlShoppingCart = value;
        }

        public UserControlMyPage _UserControlMyPage
        {
            get => userControlMyPage;
            set => userControlMyPage = value;
        }

        public UserControlChangeInformations _UserControlChangeInformations
        {
            get => userControlChangeInformations;
            set => userControlChangeInformations = value;
        }

        public static FormMainPage Instance()
        {
            if (mainPage == null)
            {
                mainPage = new FormMainPage();
            }
            return mainPage;
        }

        public FormMainPage()
        {
            InitializeComponent();
            mainPage = this;
            userControlBooks = new UserControlBooks();
            userControlMusicCDs = new UserControlMusicCDs();
            UserControlMagazines = new UserControlMagazines();
            userControlShoppingCart = new UserControlShoppingCart();
            userControlProductDetails = UserControlProductDetails.CreateProductDetails();
            userControlMusicCDDetail = UserControlMusicCDDetail.CreateMusicCDDeatils();
            userControlMagazineDetails = UserControlMagazineDetails.CreateMagazineDetails();
            userControlChangeInformations = new UserControlChangeInformations();
            userControlMyPage = UserControlMyPage.CreateMyPage();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            userControlBooks.Visible = true;
            userControlMusicCDs.Visible = false;
            UserControlMagazines.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;
            userControlBooks.DeleteBook();
            userControlBooks.CreateBook();

            this.panelProductDisplay.Controls.Add(userControlBooks);
        }

        private void btnMusicCDs_Click(object sender, EventArgs e)
        {
            userControlMusicCDs.Visible = true;
            userControlBooks.Visible = false;
            UserControlMagazines.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;

            userControlMusicCDs.DeleteMusicCD();
            userControlMusicCDs.CreateMusicCD();

            this.panelProductDisplay.Controls.Add(userControlMusicCDs);
        }

        private void btnMagazines_Click(object sender, EventArgs e)
        {
            UserControlMagazines.Visible = true;
            userControlMusicCDs.Visible = false;
            userControlBooks.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;

            UserControlMagazines.DeleteMagazine();
            UserControlMagazines.CreateMagazine();

            this.panelProductDisplay.Controls.Add(UserControlMagazines);
        }

        private void btnMyPage_Click(object sender, EventArgs e)
        {
            UserControlMagazines.Visible = false;
            userControlMusicCDs.Visible = false;
            userControlBooks.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyPage.Visible = true;
            userControlChangeInformations.Visible = false;

            userControlMyPage.SetLabelMyPage();
            this.panelProductDisplay.Controls.Add(userControlMyPage);
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            UserControlMagazines.Visible = false;
            userControlMusicCDs.Visible = false;
            userControlBooks.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;
            userControlShoppingCart.Visible = true;

            userControlShoppingCart.ListCart();
            this.panelProductDisplay.Controls.Add(userControlShoppingCart);
        }
    }
}