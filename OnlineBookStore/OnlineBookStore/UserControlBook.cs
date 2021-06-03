using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlBook : UserControl
    {
        private UserControlProductDetails userControlProductDetails = UserControlProductDetails.CreateProductDetails();
        private Book book = new Book();

        public Book _Book
        {
            get => book;
            set => book = value;
        }

        public UserControlBook()
        {
            InitializeComponent();
        }

        public void SetLabelBook(string name, string Price)//küçük booklar için
        {
            Database database = Database.CreateSingle();
            database.GetConnection();

            lblName.Text = name;
            lblPrice.Text = Price;

            string imagename = "";
            var dirs = Directory.GetFiles(@"Book Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
            SqlCommand command = new SqlCommand("SELECT ImagePath FROM dbo.Books WHERE name = @name", Database.CreateSingle().Sqlconnection);
            command.Parameters.AddWithValue("@name", lblName.Text);
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
                    pictureBoxBook.Image = new Bitmap(item);
                }
            }
        }

        private void btnReadMore_Click(object sender, EventArgs e)
        {
            FormMainPage.Instance()._UserControlBooks.Visible = false;
            FormMainPage.Instance()._UserControlMusicCDs.Visible = false;
            FormMainPage.Instance()._UserControlMagazines.Visible = false;
            FormMainPage.Instance()._UserControlShoppingCart.Visible = false;

            userControlProductDetails.SetBookInfo(book.ProductName, book.Author, book.Publisher,
            book.Page, book.BookISBN, book.ProductPrice, book.Cover, book.Type);
            FormMainPage.Instance().panelProductDisplay.Controls.Add(userControlProductDetails);

            userControlProductDetails.Visible = true;
        }
    }
}