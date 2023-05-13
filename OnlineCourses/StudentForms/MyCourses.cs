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
    public partial class MyCourses : Form
    {
        int id;
        CourseList courselist = new CourseList();

        public MyCourses(int _id)
        {
            InitializeComponent();
            id = _id;
            courselist = CoursesMethod.GetList(id);
            FillListBox();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (lbCourses.SelectedItem != null)
            {
                new CourseInfo(lbCourses.SelectedItem.ToString(), id).Show();

            }
            else MessageBox.Show("Оберіть курс");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbCourses.SelectedItem != null)
            {
                CourseList.RemoveCourse(id, lbCourses.SelectedItem.ToString());
                lbCourses.Items.Remove(lbCourses.SelectedItem);
            }
            else MessageBox.Show("Оберіть курс");
        }

        private void MyCourses_Load(object sender, EventArgs e)
        {

        }
        private void FillListBox()
        {
            if (File.Exists("students_courses.xml"))
            {
                if (CourseList.Deserialise().Any(x => x.StudentId == id))
                {
                    foreach (var item in courselist.Courses)
                    {
                        lbCourses.Items.Add(item);
                    }
                }

            }

        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
