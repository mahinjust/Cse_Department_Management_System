using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Attendance.Staff_Attendance
{
    public partial class Staff_Attendance : Form
    {
        public Staff_Attendance()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Staff st = new Staff())
            {
                st.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Staff st = new Staff())
            {
                st.ShowDialog();
            }
        }
    }
}
