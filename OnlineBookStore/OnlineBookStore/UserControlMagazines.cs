using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class UserControlMagazines : UserControl
    {
        public FlowLayoutPanel panel
        {
            get => flowLayoutPanelProductDisplay;
        }
        private static UserControlMagazines controlMagazines;
        public static UserControlMagazines CreateControlMagazines()
        {
            if (controlMagazines == null)
            {
                controlMagazines = new UserControlMagazines();
            }
            return controlMagazines;
        }

        protected UserControlMagazines()
        {
            controlMagazines = this;
            InitializeComponent();
        }

        public void DeleteMagazine()
        {
            flowLayoutPanelProductDisplay.Controls.Clear();
        }
    }
}