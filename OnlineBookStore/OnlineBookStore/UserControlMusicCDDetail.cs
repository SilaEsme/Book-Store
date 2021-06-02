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
    public partial class UserControlMusicCDDetail : UserControl
    {
        private static UserControlMusicCDDetail userControlMusicCDDetail;
        public UserControlMusicCDDetail()
        {
            InitializeComponent();
        }
        public static UserControlMusicCDDetail CreateMusicCDDeatils()
        {
            if (userControlMusicCDDetail == null)
                userControlMusicCDDetail = new UserControlMusicCDDetail();
            return userControlMusicCDDetail;
        }

        public void SetMusicCDInfo(string name, string Singer, string Price,
         typeCD type)
        {
            lblName.Text = name;
            lblSinger.Text = Singer;        
            lblPrice.Text = Price;
            lblType.Text = type.ToString();
        }
    }
}
