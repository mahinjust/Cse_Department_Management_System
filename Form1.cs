using Cse_Department.Assets;
using Cse_Department.Class;
using Cse_Department.Employee;
using Cse_Department.Examination;
using Cse_Department.Expenses;
using Cse_Department.Fee;
using Cse_Department.Notices;
using Cse_Department.Papers;
using Cse_Department.Parent;
using Cse_Department.Salary;
using Cse_Department.Settings;
using Cse_Department.Student;
using Cse_Department.Subjects;
using Cse_Department.Teacher;
using Cse_Department.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cse_Department
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Details cls = new Class_Details();
            cls.MdiParent = Form1.ActiveForm;
            cls.Show();

        }

        private void guardiansToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addGuardiansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parent_Details prnt = new Parent_Details();
            prnt.MdiParent = Form1.ActiveForm;
            prnt.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Details std = new Student_Details();
            std.MdiParent = Form1.ActiveForm;
            std.Show();
        }

        private void addSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subjects_Details sub = new Subjects_Details();
            sub.MdiParent = Form1.ActiveForm;
            sub.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher_Details teacher = new Teacher_Details();
            teacher.MdiParent = Form1.ActiveForm;
            teacher.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Details emp = new Employee_Details();
            emp.MdiParent = Form1.ActiveForm;
            emp.Show();
        }

        private void addExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses_Details exp = new Expenses_Details();
            exp.MdiParent = Form1.ActiveForm;
            exp.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fee_Details fee = new Fee_Details();
            fee.MdiParent = Form1.ActiveForm;
            fee.Show();
        }

        private void newSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Details sal = new Salary_Details();
            sal.MdiParent = Form1.ActiveForm;
            sal.Show();
        }

        private void addPapersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paper_Details ppr = new Paper_Details();
            ppr.MdiParent = Form1.ActiveForm;
            ppr.Show();
        }

        private void addExamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam_Details exm = new Exam_Details();
            exm.MdiParent = Form1.ActiveForm;
            exm.Show();
        }

        private void newNoticesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notices_Details ntc = new Notices_Details();
            ntc.MdiParent = Form1.ActiveForm;
            ntc.Show();
        }

        private void addCtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test_Details ct = new Test_Details();
            ct.MdiParent = Form1.ActiveForm;
            ct.Show();

        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffsAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance.Staff_Attendance.Staff_Attendance sa = new Attendance.Staff_Attendance.Staff_Attendance();
            sa.MdiParent = Form1.ActiveForm;
            sa.Show();

        }

        private void attendanceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance.Student_Attendance.Student_Attendance sa = new Attendance.Student_Attendance.Student_Attendance();
            sa.MdiParent = Form1.ActiveForm;
            sa.Show();
        }

        private void teachersAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance.Teacher_Attendance.Teacher_Attendance sa = new Attendance.Teacher_Attendance.Teacher_Attendance();
            sa.MdiParent = Form1.ActiveForm;
            sa.Show();
        }

        private void addAssetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assets_Details ast = new Assets_Details();
            ast.MdiParent = Form1.ActiveForm;
            ast.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users usr = new Users();
            usr.MdiParent = Form1.ActiveForm;
            usr.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting rpr = new Reporting();
            rpr.MdiParent = Form1.ActiveForm;
            rpr.Show();
        }
    }
    }

