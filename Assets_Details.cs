using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Assets
{
    public partial class Assets_Details : Form
    {
        public Assets_Details()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Asset ast = new Asset())
            {
                ast.lbl = "Add Information Here!";
                ast.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Asset ast = new Asset())
            {
                ast.lbl = "Update Information Here!";
                ast.ShowDialog();
            }
        }
    }
}
