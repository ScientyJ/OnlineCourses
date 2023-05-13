using OnlineCourses.ClassFolder;
using OnlineCourses.Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCourses.AdminForms
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
            FillTeacherStudentListBox();
            FillCourseListBox();
        }

        private void lbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FillTeacherStudentListBox()
        {
            if (lbStudents.Items.Count > 0 || lbTeachers.Items.Count > 0)
            {
                lbStudents.Items.Clear();
                lbTeachers.Items.Clear();
            }
            var users = CoursesMethod.DeserialiseUserList();
            foreach (var user in users)
            {
                if (user.Role.Equals("student"))
                {
                    lbStudents.Items.Add(user.Name + " " + user.Surname);
                }
                else if (user.Role.Equals("teacher"))
                {
                    lbTeachers.Items.Add(user.Name + " " + user.Surname);
                }
            }
        }

        private void FillCourseListBox()
        {
            if (lbCourses.Items.Count > 0)
            {
                lbCourses.Items.Clear();
            }
            var courses = CoursesMethod.DeserialiseCourseList();
            foreach (var course in courses)
            {
                lbCourses.Items.Add(course.Name);
            }
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {

            if (lbStudents == null && lbTeachers == null)
            {
                MessageBox.Show("Choose USER");
            }
            else
            {
                string nameandsurname = null;
                if (lbStudents != null) nameandsurname = lbStudents.Text;
                else if (lbTeachers != null) nameandsurname = lbTeachers.Text;
                string[] nameParts = nameandsurname.Split(' ');
                var users = CoursesMethod.DeserialiseUserList();
                users.RemoveAt(users.FindIndex(x => x.Name == nameParts[0] && x.Surname == nameParts[1]));
                CoursesMethod.SerialiseUserList(users);
                FillTeacherStudentListBox();
                MessageBox.Show("Succesfull");
            }
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            if (lbCourses == null)
            {
                MessageBox.Show("Choose COURSE");
            }
            else
            {
                CoursesMethod.DeleteCourse(lbCourses.Text);
                FillCourseListBox();
                MessageBox.Show("Succesfull");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
