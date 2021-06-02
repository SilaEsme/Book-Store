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
    public partial class UserControlMusicCD : UserControl
    {
        UserControlMusicCDDetail userControlMusicCDDetail = UserControlMusicCDDetail.CreateMusicCDDeatils();
        MusicCD musicCD = new MusicCD();
        public UserControlMusicCD()
        {
            InitializeComponent();
        }
        public void SetLabelMusicCD(string name, string Price)//küçük booklar için
        {
            lblName.Text = name;
            lblPrice.Text = Price;
        }
        public MusicCD _musicCD
        {
            get => musicCD;
            set => musicCD = value;
        }
        private void btnReadMore_Click(object sender, EventArgs e)
        {
            FormMainPage.Instance()._UserControlBooks.Visible = false;
            FormMainPage.Instance()._UserControlMusicCDs.Visible = false;
            FormMainPage.Instance()._UserControlMagazines.Visible = false;
            FormMainPage.Instance()._UserControlShoppingCart.Visible = false;

            userControlMusicCDDetail.SetMusicCDInfo(musicCD.Name, musicCD.Singer, musicCD.Price,
            musicCD.Type);
            FormMainPage.Instance().panelProductDisplay.Controls.Add(userControlMusicCDDetail);

            userControlMusicCDDetail.Visible = true;
        }
    }
}
