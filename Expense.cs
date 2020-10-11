using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Expenses
{
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }
        public string lbl;
        private void Expense_Load(object sender, EventArgs e)
        {
            lblexp.Text = lbl;
            if(lblexp.Text== "Add Information Here!")
            {
                btnadd.Text = "Add";
            }
            else if (lblexp.Text == "Update Information Here!")
            {
                btnadd.Text = "Update";
            }
        }

        private void lblexp_Click(object sender, EventArgs e)
        {

        }
    }
}
