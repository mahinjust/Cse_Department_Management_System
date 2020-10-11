using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Test
{
    public partial class Add_Test : Form
    {
        public Add_Test()
        {
            InitializeComponent();
        }
        public string lbl;
        private void Add_Test_Load(object sender, EventArgs e)
        {
            lblct.Text = lbl;
            if (lblct.Text == "Add Information Here!")
            {
                btnadd.Text = "Add";
            }
            else if (lblct.Text == "Update Information Here!")
            {
                btnadd.Text = "Update";
            }
        }
    }
}
