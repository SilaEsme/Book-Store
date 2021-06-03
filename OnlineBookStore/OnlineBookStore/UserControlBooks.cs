using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlBooks : UserControl
    {
        public FlowLayoutPanel Panel
        {
            get => flowLayoutPanelProductDisplay;
        }
        private static UserControlBooks controlBooks;
        public static UserControlBooks CreateControlBooks()
        {
            if (controlBooks == null)
            {
                controlBooks = new UserControlBooks();
            }
            return controlBooks;
        }
        protected UserControlBooks()
        {
            controlBooks = this;
            InitializeComponent();
        }

        public void DeleteBook()
        {
            flowLayoutPanelProductDisplay.Controls.Clear();
        }
    }
}