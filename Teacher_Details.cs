using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Teacher
{
    public partial class Teacher_Details : Form
    {
        public Teacher_Details()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Teacher tchr = new Teacher())
            {
                tchr.lbl = "Add Information here!";
                tchr.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Teacher tchr = new Teacher())
            {
                tchr.lbl = "Update Information here!";
                tchr.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
