using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department.Attendance.Student_Attendance
{
    public partial class Student_Attendance : Form
    {
        public Student_Attendance()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Student st = new Student())
            {
                st.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Student st = new Student())
            {
                st.ShowDialog();
            }
        }
    }
}
