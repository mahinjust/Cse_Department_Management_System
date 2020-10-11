using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Attendance.Teacher_Attendance
{
    public partial class Teacher_Attendance : Form
    {
        public Teacher_Attendance()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Teacher st = new Teacher())
            {
                st.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Teacher st = new Teacher())
            {
                st.ShowDialog();
            }
        }
    }
}
