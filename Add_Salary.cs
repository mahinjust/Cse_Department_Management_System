using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Salary
{
    public partial class Add_Salary : Form
    {
        public Add_Salary()
        {
            InitializeComponent();
        }
        public string lbl;
        private void Add_Salary_Load(object sender, EventArgs e)
        {
            lblsal.Text = lbl;
            if (lblsal.Text== "Add Information Here!")
            {
                btnadd.Text = "Add";
            }
            else if(lblsal.Text == "Update Information Here!")
            {
                btnadd.Text = "Update";
            }
        }
    }
}
