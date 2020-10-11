using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Notices
{
    public partial class Add_Notices : Form
    {
        public Add_Notices()
        {
            InitializeComponent();
        }
        public string lbl;
        private void Add_Notices_Load(object sender, EventArgs e)
        {
            lblntc.Text = lbl;
            if (lblntc.Text == "Add Information Here!")
            {
                btnadd.Text = "Add";
            }
            else if (lblntc.Text == "Update Information Here!")
            {
                btnadd.Text = "Update";
            }
        }
    }
}
