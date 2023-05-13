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
using System.Xml.Serialization;

namespace OnlineCourses.TeacherForms
{
    public partial class TeacherMainForm : Form
    {

        int id;
        public TeacherMainForm(int _id)
        {
            InitializeComponent();
            id = _id;
            FillCourseListBox();
            FillStudentListBox();


        }

        private void TeacherMainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            CreateCourse createCourseForm = new CreateCourse(id);
            createCourseForm.ShowDialog();
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillCourseListBox()
        {
            if (File.Exists("courses.xml"))
            {
                var courselist = CoursesMethod.DeserialiseCourseList();
                foreach (var course in courselist)
                {
                    if (course.TeacherId == id)
                    {
                        lbCourses.Items.Add(course.Name);
                    }
                }
            }

        }
        private void FillStudentListBox()
        {
            var Courses = CoursesMethod.DeserialiseCourseList();
            var mycourseList = new List<string>();
            foreach (var item in Courses)
            {
                if (item.TeacherId == id)
                {
                    mycourseList.Add(item.Name);
                }
            }
            var courselist = CourseList.Deserialise();
            var studentIdList = new List<int>();
            foreach (var item in courselist)
            {
                foreach (var _item in item.Courses)
                {
                    if (mycourseList.Contains(_item))
                    {
                        studentIdList.Add(item.StudentId);
                    }

                }
            }
            studentIdList = studentIdList.GroupBy(x => x).Select(x => x.First()).ToList();
            foreach (var item in studentIdList)
            {
                lbStuents.Items.Add(CoursesMethod.GetUser(item).Name + " " + CoursesMethod.GetUser(item).Surname);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbCourses.SelectedItems[0] != null)
            {
                CoursesMethod.DeleteCourse(lbCourses.SelectedItem.ToString());
                lbCourses.Items.Clear();
                FillCourseListBox();

            }
            else MessageBox.Show("Оберіть курс");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbCourses.SelectedItems[0] != null)
            {
                new UpdateCourse(CoursesMethod.GetCourse(lbCourses.SelectedItems[0].ToString())).Show();
            }
            else MessageBox.Show("Оберіть курс");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbCourses.Items.Clear();
            lbStuents.Items.Clear();
            FillCourseListBox();
            FillStudentListBox();

        }

        private void lbStuents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbStuents.SelectedItems != null)
            {
                new StudentDetails(lbStuents.SelectedItems[0].ToString()).Show();
            }
        }
    }
}
