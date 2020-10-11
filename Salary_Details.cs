using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Salary
{
    public partial class Salary_Details : Form
    {
        public Salary_Details()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Add_Salary sal = new Add_Salary())
            {
                sal.lbl = "Add Information Here!";
                sal.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Add_Salary sal = new Add_Salary())
            {
                sal.lbl = "Update Information Here!";
                sal.ShowDialog();
            }
        }
    }
}
