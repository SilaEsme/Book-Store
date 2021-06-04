using System;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class FormMainPage : Form
    {
        private static FormMainPage mainPage;

        private ProductFactory factory = new ProductFactory();
        private UserControlBooks userControlBooks;
        private UserControlMusicCDs userControlMusicCDs;
        private UserControlMagazines UserControlMagazines;
        private UserControlShoppingCart userControlShoppingCart;

        private UserControlProductDetails userControlProductDetails;
        private UserControlMusicCDDetail userControlMusicCDDetail;
        private UserControlMagazineDetails userControlMagazineDetails;
        private UserControlChangeInformations userControlChangeInformations;
        private UserControlMyPage userControlMyPage;
        private UserControlPayment userControlPayment;
        private UserControlMyOrders userControlMyOrders;
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
            factory = new ProductFactory();
            userControlBooks = UserControlBooks.CreateControlBooks();
            userControlMusicCDs = UserControlMusicCDs.CreateControlCDs();
            UserControlMagazines = UserControlMagazines.CreateControlMagazines();
            userControlShoppingCart = UserControlShoppingCart.Instance();

            userControlProductDetails = UserControlProductDetails.CreateProductDetails();
            userControlMusicCDDetail = UserControlMusicCDDetail.CreateMusicCDDeatils();
            userControlMagazineDetails = UserControlMagazineDetails.CreateMagazineDetails();
            userControlChangeInformations = new UserControlChangeInformations();
            userControlMyPage = UserControlMyPage.CreateMyPage();
            userControlPayment = UserControlPayment.CreateUserControlPayment();
            userControlMyOrders = UserControlMyOrders.CreateUserControlMyORders();
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
            userControlPayment.Visible = false;
            userControlMyOrders.Visible = false;

            userControlChangeInformations.Visible = false;
            userControlBooks.DeleteBook();
            factory.CreateProduct("Book");

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
            userControlMyOrders.Visible = false;

            userControlPayment.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;

            userControlMusicCDs.DeleteMusicCD();
            userControlMusicCDs.CreateMusicCD();

            this.panelProductDisplay.Controls.Add(userControlMusicCDs);
        }

        private void btnMagazines_Click(object sender, EventArgs e)
        {
            UserControlMagazines.Visible = true;
            UserControlMagazines.BringToFront();
            userControlMusicCDs.Visible = false;
            userControlBooks.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyOrders.Visible = false;

            userControlPayment.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;

            UserControlMagazines.DeleteMagazine();
            factory.CreateProduct("Magazine");

            this.panelProductDisplay.Controls.Add(UserControlMagazines);
        }

        private void btnMyPage_Click(object sender, EventArgs e)
        {
            UserControlMagazines.Visible = false;
            userControlMusicCDs.Visible = false;
            userControlBooks.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlPayment.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyOrders.Visible = false;

            userControlMyPage.Visible = true;
            userControlMyPage.BringToFront();
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
            userControlPayment.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;
            userControlMyOrders.Visible = false;

            userControlShoppingCart.Visible = true;
            userControlShoppingCart.BringToFront();
            userControlShoppingCart.ShoppingCart.ListCart();
            this.panelProductDisplay.Controls.Add(userControlShoppingCart);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void FormMainPage_Load(object sender, EventArgs e)
        {
            btnBooks_Click(sender,e);
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {

            userControlBooks.Visible = false;
            userControlMusicCDs.Visible = false;
            UserControlMagazines.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            userControlMyPage.Visible = false;
            userControlChangeInformations.Visible = false;
            userControlPayment.Visible = false;

            userControlMyOrders.DeleteOrders();

            if(userControlMyOrders.CreateOrder()==false)
            {
                DialogResult dialog = new DialogResult();
                dialog= MessageBox.Show("You have not ordered anything yet!", "Fail Order", MessageBoxButtons.OK);
                if(dialog == DialogResult.OK)
                {
                    btnShoppingCart_Click(sender,e);
                }
            }
            else
            {
                userControlMyOrders.Visible = true;
                userControlMyOrders.BringToFront();
                this.panelProductDisplay.Controls.Add(userControlMyOrders);
            }
           

        }
    }
}