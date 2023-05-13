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
using static OnlineCourses.TeacherForms.TeacherMainForm;

namespace OnlineCourses.TeacherForms
{
    public partial class CreateCourse : Form
    {

        int id;
        public CreateCourse(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            if (tbName.Text != null && tbLength.Text != null && tbSubject.Text != null && tbPrice.Text != null && tbBio.Text != null)
            {
                var courselist = new List<Course>();
                if (File.Exists("courses.xml"))
                {
                    courselist = CoursesMethod.DeserialiseCourseList();
                }
                courselist.Add(new Course(tbName.Text, tbSubject.Text, int.Parse(tbLength.Text), double.Parse(tbPrice.Text), tbBio.Text, id));
                CoursesMethod.SerialiseCourseList(courselist);
                MessageBox.Show("Успішно");
                this.Close();

            }
            else labelAlert.Text = "Усі поля мають бути заповнені";
        }
        public void FormClosed()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void tbSubject_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void tbLength_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void tbBio_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelAlert_Click(object sender, EventArgs e)
        {
        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
