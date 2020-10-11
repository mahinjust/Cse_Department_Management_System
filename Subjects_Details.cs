using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Subjects
{
    public partial class Subjects_Details : Form
    {
        public Subjects_Details()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Subject sub = new Subject())
            {
                sub.lbl = "Add Information Here!";
                sub.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Subject sub = new Subject())
            {
                sub.lbl = "Update Information Here!";
                sub.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
