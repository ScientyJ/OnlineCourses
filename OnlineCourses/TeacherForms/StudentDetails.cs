using OnlineCourses.Method;
using OnlineCourses.UserFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCourses.TeacherForms
{
    public partial class StudentDetails : Form
    {
        public StudentDetails(string _nameandsurname)
        {
            InitializeComponent();
            string nameandsurname = _nameandsurname;
            string[] nameParts = nameandsurname.Split(' ');
            var student = CoursesMethod.GetStudent(nameParts[0], nameParts[1]);
            tbName.Text = student.Name;
            tbSurname.Text = student.Surname;
            tbEmail.Text = student.EMail;


        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
