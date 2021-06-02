using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace OnlineBookStore
{
    public partial class UserControlBooks : UserControl
    {
        public UserControlBooks()
        {
            InitializeComponent();
            this.CreateBook();
        }

        public void CreateBook()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Books", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Book book = new Book();

                UserControlBook userControlBook = new UserControlBook();
                userControlBook.SetLabelBook(dr.GetString(0), dr.GetString(5));
                flowLayoutPanelProductDisplay.Controls.Add(userControlBook);

                book.Name = dr.GetString(0);
                book.Author = dr.GetString(1);
                book.Publisher = dr.GetString(2);
                book.Page = dr.GetString(3);
                book.BookISBN = dr.GetString(4);
                book.Price = dr.GetString(5);
                book.Cover = dr.GetString(6);
                book.Type = (_type) Enum.Parse(typeof(_type), dr.GetString(7));
                userControlBook._Book = book;
            }
            Database.CreateSingle().Sqlconnection.Close();
        }
    } 
}
