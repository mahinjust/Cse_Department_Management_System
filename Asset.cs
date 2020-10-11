using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Assets
{
    public partial class Asset : Form
    {
        public Asset()
        {
            InitializeComponent();
        }
        public string lbl;
        private void Asset_Load(object sender, EventArgs e)
        {
            lblast.Text = lbl;
            if (lblast.Text == "Add Information Here!")
            {
                btnadd.Text = "Add";
            }
            else if (lblast.Text == "Update Information Here!")
            {
                btnadd.Text = "Update";
            }
        }
    }
}
