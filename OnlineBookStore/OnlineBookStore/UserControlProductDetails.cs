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
    public partial class UserControlProductDetails : UserControl
    {
        private static UserControlProductDetails userControlProductDetails;
        public static UserControlProductDetails CreateProductDetails()
        {
            if (userControlProductDetails == null)
                userControlProductDetails = new UserControlProductDetails();
            return userControlProductDetails;
        }
        public UserControlProductDetails()
        {
            InitializeComponent();        
        }
        public void SetBookInfo(string name, string author, string publisher,
        string page, string ISBN, string price, string cover, _type type)
        {
            lblName.Text = name;
            lblAuthor.Text = author;
            lblPublisher.Text = publisher;
            lblPage.Text = page;
            lblISBN.Text = ISBN;
            lblPrice.Text = price;
            lblCover.Text = cover;
            lblType.Text = type.ToString();
        }
    }
    
}
