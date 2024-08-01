using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMangementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                Login lForm = new Login();
                lForm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_btn_Click(object sender, EventArgs e)
        {

            addStudentForm1.Visible = true;
            addTeacher1.Visible = false;
            salary1.Visible = false;
        }
        private void Salary_btn(object sender, EventArgs e)
        {
            addStudentForm1.Visible = false;
            addTeacher1.Visible = false;
            salary1.Visible = true;
            salary1.displayTeachers();
        }

        private void AddTeachers_btn_Click(object sender, EventArgs e)
        {
            addStudentForm1.Visible = false;
            salary1.Visible = false;
            addTeacher1.Visible = true;
            addTeacher1.displayTeacherData();
        }
    }
}
