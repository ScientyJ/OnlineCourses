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

namespace OnlineCourses.StudentForms
{
    public partial class StudentMainForm : Form
    {
        int id;
        public StudentMainForm(int _id)
        {
            InitializeComponent();
            id = _id;
            FillCourseListBox();
            FillTeacherListBox();
        }

        private void btnMyCourses_Click(object sender, EventArgs e)
        {

            new MyCourses(id).Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (lbTeachers.SelectedItem != null)
            {
                new TeacherInfo(lbTeachers.SelectedItem.ToString()).Show();
            }
            else if (lbCourses.SelectedItem != null)
            {
                new CourseInfo(lbCourses.SelectedItem.ToString(), id).Show();
            }

        }
        private void FillCourseListBox()
        {
            if (File.Exists("courses.xml"))
            {
                var courselist = CoursesMethod.DeserialiseCourseList();
                foreach (var course in courselist)
                {
                    lbCourses.Items.Add(course.Name);
                }
            }
        }
        private void FillTeacherListBox()
        {
            if (File.Exists("courses.xml"))
            {
                var userlist = CoursesMethod.DeserialiseUserList();
                foreach (var item in userlist)
                {
                    if (item.Role.Equals("teacher")) lbTeachers.Items.Add(item.Name + " " + item.Surname);

                }
            }
        }


        private void lbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCourses.ClearSelected();
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTeachers.ClearSelected();

        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
