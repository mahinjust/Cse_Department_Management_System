using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Class
{
    public partial class Add_Class : Form
    {
        public Add_Class()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public string lbl;

        private void Add_Class_Load(object sender, EventArgs e)
        {

            lblclass.Text = lbl;
            if(lblclass.Text== "Add Information Here!")
            {
                btnadd.Text = "Add";
            }
            else if(lblclass.Text == "Update Information Here!")
            {
                btnadd.Text = "Update";
            }
        }
    }
}
