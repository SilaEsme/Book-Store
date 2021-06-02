﻿using System;
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
    public partial class UserControlBook : UserControl
    {
        UserControlProductDetails userControlProductDetails = UserControlProductDetails.CreateProductDetails();
        Book book = new Book();
        public Book _Book
        {
            get => book;
            set => book = value;
        }
        public UserControlBook()
        {
            InitializeComponent();
        }
        public void SetLabelBook(string name,string Price)//küçük booklar için
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

            userControlProductDetails.SetBookInfo(book.Name, book.Author, book.Publisher,
            book.Page, book.BookISBN, book.Price, book.Cover, book.Type);
            FormMainPage.Instance().panelProductDisplay.Controls.Add(userControlProductDetails);
           
            userControlProductDetails.Visible = true;
        }
    }
}