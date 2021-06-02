using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlBooks : UserControl
    {
        private SqlDependency dependency;

        public UserControlBooks()
        {
            InitializeComponent();
            //this.CreateBook();
        }

        //private void Dependency()
        //{
        //    dependency = new SqlDependency();
        //    SqlDependency.Start(Database.CreateSingle().ConnectionString);

        //    dependency.OnChange += Dependency_OnChange;
        //}

        //private void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
        //{
        //    MessageBox.Show("Veritabanı güncellenmiştir. " + e.Info.ToString());
        //    dependency.OnChange -= Dependency_OnChange;
        //    DeleteBook();
        //    CreateBook();
        //}

        public void CreateBook()
        {
            SqlCommand command = new SqlCommand("SELECT Name,Author,Publisher,Page_Number,ISBN,Price,Cover,Type,ID FROM dbo.Books", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            //Dependency();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Book book = new Book();

                UserControlBook userControlBook = new UserControlBook();
                userControlBook.SetLabelBook(dr.GetString(0), dr.GetString(5));
                flowLayoutPanelProductDisplay.Controls.Add(userControlBook);

                book.ProductName = dr.GetString(0);
                book.Author = dr.GetString(1);
                book.Publisher = dr.GetString(2);
                book.Page = dr.GetString(3);
                book.BookISBN = dr.GetString(4);
                book.ProductPrice = dr.GetString(5);
                book.Cover = dr.GetString(6);
                book.Type = (_type)Enum.Parse(typeof(_type), dr.GetString(7));
                userControlBook._Book = book;
            }
            Database.CreateSingle().Sqlconnection.Close();
        }

        public void DeleteBook()
        {
            flowLayoutPanelProductDisplay.Controls.Clear();
        }
    }
}