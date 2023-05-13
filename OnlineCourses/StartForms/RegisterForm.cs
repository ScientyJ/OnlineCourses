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

namespace OnlineCourses.StartForms
{
    public partial class RegisterForm : Form
    {
        string role;
        public RegisterForm()
        {
            InitializeComponent();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (role == null)
            {
                labelRole.Text = "Оберіть";

            }
            else if (CoursesMethod.IsLogin(tbLogin.Text))
            {
                labelLogin.Text = "Уже використовується";
            }
            else
            {
                var userlist = new List<User>();
                if (File.Exists("users.xml"))
                {
                    userlist = CoursesMethod.DeserialiseUserList();
                } 
                userlist.Add(new User(tbLogin.Text, tbPassword.Text, tbEmail.Text, role, tbName.Text, tbSurname.Text));
                CoursesMethod.SerialiseUserList(userlist);
                this.Close();
                MessageBox.Show("Успішно");
            }

        }

        private void rbStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStudent.Checked)
            {
                rbTeacher.Checked = false;
            }
            role = "student";
        }

        private void rbTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTeacher.Checked)
            {
                rbStudent.Checked = false;
            }
            role = "teacher";
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
