using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlShoppingCart : UserControl
    {
        private ShoppingCart ShoppingCart = new ShoppingCart();

        public UserControlShoppingCart()
        {
            InitializeComponent();
        }

        private void GetList()
        {
            SqlCommand command = new SqlCommand("SELECT ProductName, Price, Amount, ProductType FROM dbo.ShoppingCart where Username = '" + Customer.CreateCustomer().userInfo.Username + "'", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (dr.GetString(3) == "Book")
                {
                    Book book = new Book();
                    ItemToPurchase itemToPurchase = new ItemToPurchase();
                    book.ProductName = dr.GetString(0);
                    book.ProductPrice = dr.GetString(1);
                    itemToPurchase.Product = book;
                    itemToPurchase.Quantity = dr.GetString(2);
                    ShoppingCart.AddProduct(itemToPurchase);
                }
                else if (dr.GetString(3) == "MusicCD")
                {
                    MusicCD cd = new MusicCD();
                    ItemToPurchase itemToPurchase = new ItemToPurchase();
                    cd.ProductName = dr.GetString(0);
                    cd.ProductPrice = dr.GetString(1);
                    itemToPurchase.Product = cd;
                    itemToPurchase.Quantity = dr.GetString(2);
                    ShoppingCart.AddProduct(itemToPurchase);
                }
                else if (dr.GetString(3) == "Magazine")
                {
                    Magazine magazine = new Magazine();
                    ItemToPurchase itemToPurchase = new ItemToPurchase();
                    magazine.ProductName = dr.GetString(0);
                    magazine.ProductPrice = dr.GetString(1);
                    itemToPurchase.Product = magazine;
                    itemToPurchase.Quantity = dr.GetString(2);
                    ShoppingCart.AddProduct(itemToPurchase);
                }
            }
            Database.CreateSingle().Sqlconnection.Close();
        }

        public void ListCart()
        {
            ShoppingCart.List.Clear();
            flowLayoutPanelProducts.Controls.Clear();
            GetList();
            double totalprice = 0;
            int totalamount = 0;
            foreach (var item in ShoppingCart.List)
            {
                UserControlShoppingCartItem cartItem = new UserControlShoppingCartItem();
                cartItem.SetLabel(item.Product.ProductName, item.Product.ProductPrice, item.Quantity);
                flowLayoutPanelProducts.Controls.Add(cartItem);
                item.Product.ProductPrice = item.Product.ProductPrice.Replace('.', ',');

                totalprice += Double.Parse(item.Product.ProductPrice) * Int32.Parse(item.Quantity);
                totalamount += Int32.Parse(item.Quantity);
            }
            lblTotalPrice.Text = totalprice.ToString().Replace(',', '.');
            lblTotalAmount.Text = totalamount.ToString();
        }
    }
}