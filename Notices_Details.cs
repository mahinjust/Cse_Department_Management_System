using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Notices
{
    public partial class Notices_Details : Form
    {
        public Notices_Details()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Add_Notices ntc = new Add_Notices())
            {
                ntc.lbl = "Add Information Here!";
                ntc.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Add_Notices ntc = new Add_Notices())
            {
                ntc.lbl = "Update Information Here!";
                ntc.ShowDialog();
            }
        }
    }
}
