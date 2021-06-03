using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMusicCD : UserControl
    {
        private UserControlMusicCDDetail userControlMusicCDDetail = UserControlMusicCDDetail.CreateMusicCDDeatils();
        private MusicCD musicCD = new MusicCD();

        public UserControlMusicCD()
        {
            InitializeComponent();
        }

        public void SetLabelMusicCD(string name, string Price)//küçük booklar için
        {
            lblName.Text = name;
            lblPrice.Text = Price;

            Database database = Database.CreateSingle();
            database.GetConnection();

            string imagename = "";
            var dirs = Directory.GetFiles(@"MusicCD Images", "*.*").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg"));
            SqlCommand command = new SqlCommand("SELECT ImagePath FROM dbo.Music_CDs WHERE name = @name", Database.CreateSingle().Sqlconnection);
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
                    pictureBoxMusicCD.Image = new Bitmap(item);
                }
            }
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

            userControlMusicCDDetail.SetMusicCDInfo(musicCD.ProductName, musicCD.Singer, musicCD.ProductPrice,
            musicCD.Type);
            FormMainPage.Instance().panelProductDisplay.Controls.Add(userControlMusicCDDetail);

            userControlMusicCDDetail.Visible = true;
        }
    }
}