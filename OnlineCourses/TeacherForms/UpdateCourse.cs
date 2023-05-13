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

namespace OnlineCourses.TeacherForms
{
    public partial class UpdateCourse : Form
    {
        Course course = new Course();
        public UpdateCourse(Course _course)
        {
            InitializeComponent();
            course = _course;

            tbName.Text = course.Name;
            tbSubject.Text = course.Subject;
            tbPrice.Text = course.Price.ToString();
            tbLength.Text = course.Length.ToString();
            tbBio.Text = course.Bio;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text != null && tbLength.Text != null && tbSubject.Text != null && tbPrice.Text != null && tbBio.Text != null)
            {
                CoursesMethod.UpdateCourse(new Course(tbName.Text, tbSubject.Text, int.Parse(tbLength.Text), double.Parse(tbPrice.Text), tbBio.Text, course.TeacherId), course.Name);
                this.Close();
            }
            else labelAlert.Text = "Усі поля мають бути заповнені";
        }

        private void UpdateCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
