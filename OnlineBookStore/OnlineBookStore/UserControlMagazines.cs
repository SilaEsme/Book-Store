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
    public partial class UserControlMagazines : UserControl
    {
        UserControlMagazine userControlMagazine = new UserControlMagazine();
        public UserControlMagazines()
        {
            InitializeComponent();
            this.CreateMagazine();

        }

        public void CreateMagazine()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Magazines", Database.CreateSingle().Sqlconnection);
            Database.CreateSingle().Sqlconnection.Open();
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                Magazine magazine = new Magazine();
                UserControlMagazine userControlMagazine = new UserControlMagazine();
                userControlMagazine.SetLabelMagazine(dr.GetString(0), dr.GetString(3));
                flowLayoutPanelProductDisplay.Controls.Add(userControlMagazine);
                magazine.Name = dr.GetString(0);
                magazine.Issue = dr.GetString(1);
                magazine.Price = dr.GetString(3);
                magazine._TypeMagazine = (typeMagazine)Enum.Parse(typeof(typeMagazine), dr.GetString(2));
                userControlMagazine._Magazine = magazine;
            }
            Database.CreateSingle().Sqlconnection.Close();
        }
    }
}
