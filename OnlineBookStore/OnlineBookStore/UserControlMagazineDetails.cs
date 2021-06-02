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
    public partial class UserControlMagazineDetails : UserControl
    {
        private static UserControlMagazineDetails userControlMagazineDetails;

        public static UserControlMagazineDetails CreateMagazineDetails()
        {
            if (userControlMagazineDetails == null)
                userControlMagazineDetails = new UserControlMagazineDetails();
            return userControlMagazineDetails;
        }
        public void SetMagazineInfo(string name, string Issue, string Price,
       typeMagazine type)
        {
            lblName.Text = name;
            lblIssue.Text = Issue;
            lblPrice.Text = Price;
            lblType.Text = type.ToString();
        }

        public UserControlMagazineDetails()
        {
            InitializeComponent();
        }
    }
}
