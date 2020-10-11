using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Fee
{
    public partial class Add_Fee : Form
    {
        public Add_Fee()
        {
            InitializeComponent();
        }
        public string lbl;
        private void Add_Fee_Load(object sender, EventArgs e)
        {
            lblfee.Text = lbl;
            if (lblfee.Text== "Add Information Here!")
            {
                btnadd.Text = "Add";
            }
            else if (lblfee.Text== "Update Information Here!")
            {
                btnadd.Text = "Update";
            }

        }
    }
}
