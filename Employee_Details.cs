using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Employee
{
    public partial class Employee_Details : Form
    {
        public Employee_Details()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Employee emp = new Employee())
            {
                emp.lbl = "Add Information Here!";
                emp.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Employee emp = new Employee())
            {
                emp.lbl = "Update Information Here!";
                emp.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
