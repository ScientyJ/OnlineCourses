using OnlineCourses.ClassFolder;
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

namespace OnlineCourses.StudentForms
{
    public partial class CourseInfo : Form
    {
        Course course = new Course();
        int id;
        public CourseInfo(string _name, int _id)
        {
            InitializeComponent();
            course = CoursesMethod.GetCourse(_name);
            FillTextBoxes();
            id = _id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (course != null) Student.Rate(course.Name);
            {
                int rating = int.Parse(tbRating.Text);
                rating++;
                tbRating.Text = rating.ToString();
            }

        }

        private void btnSubscribeCourse_Click(object sender, EventArgs e)
        {
            if (File.Exists("students_courses.xml"))
            {
                if (CourseList.Deserialise().Any(x => x.StudentId == id))
                {
                    if (!CourseList.IsCourseInCourseList(id, tbName.Text.ToString()))
                    {
                        CourseList.Add(id, tbName.Text);
                        MessageBox.Show("Успішно");
                    }
                    else
                    {
                        MessageBox.Show("Уже підписані");
                    }
                }
                else
                {
                    CourseList.Add(id, tbName.Text);
                }

            }

        }

        private void btnTeacherInfo_Click(object sender, EventArgs e)
        {
            new TeacherInfo(tbTeacher.Text).Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void FillTextBoxes()
        {
            tbName.Text = course.Name;
            tbSubject.Text = course.Subject;
            tbLength.Text = course.Length.ToString();
            tbPrice.Text = course.Price.ToString();
            tbTeacher.Text = CoursesMethod.GetUser(course.TeacherId).Name + " " + CoursesMethod.GetUser(course.TeacherId).Surname;
            tbRating.Text = course.Rating.ToString();
        }
        private void ClearTextBoxes()
        {
            tbName.Clear();
            tbSubject.Clear();
            tbLength.Clear();
            tbPrice.Clear();
            tbTeacher.Clear();
            tbRating.Clear();
        }

        private void CourseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
