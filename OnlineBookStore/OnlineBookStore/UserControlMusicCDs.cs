using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMusicCDs : UserControl
    {
        UserControlMusicCD userControlMusicCD = new UserControlMusicCD();
        public UserControlMusicCDs()
        {
            InitializeComponent();
            this.CreateMusicCD();

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

                musicCD.Name = dr.GetString(0);
                musicCD.Singer = dr.GetString(1);
                musicCD.Price = dr.GetString(3);
                musicCD.Type = (typeCD)Enum.Parse(typeof(typeCD), dr.GetString(2));
                userControlMusicCD._musicCD = musicCD;
            }
            Database.CreateSingle().Sqlconnection.Close();
        }
    }
   
}
