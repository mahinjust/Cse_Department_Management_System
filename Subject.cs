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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }
        public string lbl;
        private void Subject_Load(object sender, EventArgs e)
        {
            lblsub.Text = lbl;
            if (lblsub.Text== "Add Information Here!")
            {
                btnadd.Text = "Add";
            }
            else if (lblsub.Text == "Update Information Here!")
            {
                btnadd.Text = "Update";
            }
        }

        private void lblsub_Click(object sender, EventArgs e)
        {

        }
    }
}
