using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMusicCDs : UserControl
    {
        public FlowLayoutPanel panel
        {
            get => flowLayoutPanel_productDisplay;
        }
        private static UserControlMusicCDs controlMusicCDs;
        public static UserControlMusicCDs CreateControlCDs()
        {
            if (controlMusicCDs == null)
            {
                controlMusicCDs = new UserControlMusicCDs();
            }
            return controlMusicCDs;
        }

        protected UserControlMusicCDs()
        {
            controlMusicCDs = this;
            InitializeComponent();
        }

        public void CreateMusicCD()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Music_CDs", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                MusicCD musicCD = new MusicCD();

                UserControlMusicCD userControlMusicCD = new UserControlMusicCD();
                userControlMusicCD.SetLabelMusicCD(dr.GetString(0), dr.GetString(3));

                flowLayoutPanel_productDisplay.Controls.Add(userControlMusicCD);

                musicCD.ProductName = dr.GetString(0);
                musicCD.Singer = dr.GetString(1);
                musicCD.ProductPrice = dr.GetString(3);
                musicCD.Type = (typeCD)Enum.Parse(typeof(typeCD), dr.GetString(2));
                userControlMusicCD._musicCD = musicCD;
            }
            Database.CreateSingle().Sqlconnection.Close();
        }

        public void DeleteMusicCD()
        {
            flowLayoutPanel_productDisplay.Controls.Clear();
        }
    }
}