using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlShoppingCart : UserControl
    {
        private UserControlBooks userControlBooks = UserControlBooks.CreateControlBooks();
        private UserControlMusicCDs userControlMusicCDs = UserControlMusicCDs.CreateControlCDs();
        private UserControlMagazines userControlMagazines = UserControlMagazines.CreateControlMagazines();
        private UserControlProductDetails userControlProductDetails = UserControlProductDetails.CreateProductDetails();
        private UserControlMusicCDDetail userControlMusicCDDetail = UserControlMusicCDDetail.CreateMusicCDDeatils();
        private UserControlMagazineDetails userControlMagazineDetails = UserControlMagazineDetails.CreateMagazineDetails();
        UserControlPayment userControlPayment = UserControlPayment.CreateUserControlPayment();

        private ShoppingCart shoppingCart = new ShoppingCart();

        public ShoppingCart ShoppingCart
        {
            get => shoppingCart;
        }
        public FlowLayoutPanel flowLayoutPanel
        {
            get => flowLayoutPanel;
        }
        private static UserControlShoppingCart userControlShoppingCart;
        public static UserControlShoppingCart Instance()
        {
            if (userControlShoppingCart == null)
                userControlShoppingCart = new UserControlShoppingCart();
            return userControlShoppingCart;
        }
        public UserControlShoppingCart()
        {
            InitializeComponent();
            userControlShoppingCart = this;
        }
        public void SetLabelAmount(string amount)
        {
            lblTotalAmount.Text = amount;
        }
        public void SetLabelPrice(string price)
        {
            lblTotalPrice.Text = price;
        }
        public string GetLabelAmount()
        {
            return lblTotalAmount.Text;
        }
        public string GetLabelPrice()
        {
            return lblTotalPrice.Text.Replace('.',',');
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            shoppingCart.ClearCart();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            userControlMusicCDs.Visible = false;
            userControlBooks.Visible = false;
            userControlMagazines.Visible = false;
            userControlShoppingCart.Visible = false;
            userControlProductDetails.Visible = false;
            userControlMusicCDDetail.Visible = false;
            userControlMagazineDetails.Visible = false;
            FormMainPage.Instance()._UserControlMyPage.Visible = false;
            FormMainPage.Instance()._UserControlChangeInformations.Visible = false;
            userControlPayment.Visible = true;

            FormMainPage.Instance().panelProductDisplay.Controls.Add(userControlPayment);
        }
    }
}