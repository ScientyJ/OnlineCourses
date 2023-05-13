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
    public partial class TeacherInfo : Form
    {
        string nameandsurname;
        User teacher = new User();
        public TeacherInfo(string _nameandsurname)
        {
            InitializeComponent();
            nameandsurname = _nameandsurname;
            string[] nameParts = nameandsurname.Split(' ');
            teacher = CoursesMethod.GetTeacher(nameParts[0], nameParts[1]);
            FillTextBoxes();
            FillCourses();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FillTextBoxes()
        {

            tbName.Text = teacher.Name;
            tbSurname.Text = teacher.Surname;
            tbEmail.Text = teacher.EMail;
        }
        private void FillCourses()
        {
            var courselist = CoursesMethod.DeserialiseCourseList();
            foreach (var item in courselist)
            {
                if (item.TeacherId == teacher.Id)
                {
                    lbCourses.Items.Add(item.Name);
                }
            }
        }

        private void TeacherInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
