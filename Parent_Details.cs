using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Parent
{
    public partial class Parent_Details : Form
    {
        public Parent_Details()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Parent pr = new Cse_Department.Parent.Parent())
            {
                pr.lbl = "Add Information Here!";
                pr.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Parent pr = new Cse_Department.Parent.Parent())
            {
                pr.lbl = "Update Information Here!";
                pr.ShowDialog();
            }
        }
    }
}
