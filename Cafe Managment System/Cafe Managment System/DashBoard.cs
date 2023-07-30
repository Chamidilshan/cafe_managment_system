using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Managment_System
{
    public partial class DashBoard : Form
    {
        public DashBoard(string user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnRemoveItems.Hide();
                btnUpdateItems.Hide();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
