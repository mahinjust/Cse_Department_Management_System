using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Fee
{
    public partial class Fee_Details : Form
    {
        public Fee_Details()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Add_Fee fee = new Add_Fee())
            {
                fee.lbl = "Add Information Here!";
                fee.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Add_Fee fee = new Add_Fee())
            {
                fee.lbl = "Update Information Here!";
                fee.ShowDialog();
            }
        }
    }
}
