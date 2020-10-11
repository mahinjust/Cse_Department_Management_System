using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Settings
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (New_Role r1 = new New_Role())
            {
                r1.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (New_User usr = new New_User())
            {
                usr.ShowDialog();
            }
        }
    }
}
