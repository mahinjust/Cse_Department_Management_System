using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Examination
{
    public partial class Exam_Details : Form
    {
        public Exam_Details()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            using (Add_Exam exm = new Add_Exam())
            {
                exm.lbl = "Add Information Here!";
                exm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Add_Exam exm = new Add_Exam())
            {
                exm.lbl = "Update Information Here!";
                exm.ShowDialog();
            }
        }
    }
}
