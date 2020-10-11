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
    public partial class Add_Exam : Form
    {
        public Add_Exam()
        {
            InitializeComponent();
        }
        public string lbl;
        private void Add_Exam_Load(object sender, EventArgs e)
        {
            lblexm.Text = lbl;
            if (lblexm.Text == "Add Information Here!")
            {
                btnadd.Text = "Add";
            }
            else if (lblexm.Text == "Update Information Here!")
            {
                btnadd.Text = "Update";
            }
        }
    }
}
