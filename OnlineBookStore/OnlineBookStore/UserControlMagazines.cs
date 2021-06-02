using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMagazines : UserControl
    {
        private UserControlMagazine userControlMagazine = new UserControlMagazine();

        public UserControlMagazines()
        {
            InitializeComponent();
            //this.CreateMagazine();
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
                magazine.ProductName = dr.GetString(0);
                magazine.Issue = dr.GetString(1);
                magazine.ProductPrice = dr.GetString(3);
                magazine._TypeMagazine = (typeMagazine)Enum.Parse(typeof(typeMagazine), dr.GetString(2));
                userControlMagazine._Magazine = magazine;
            }
            Database.CreateSingle().Sqlconnection.Close();
        }

        public void DeleteMagazine()
        {
            flowLayoutPanelProductDisplay.Controls.Clear();
        }
    }
}