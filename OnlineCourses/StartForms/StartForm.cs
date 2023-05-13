using OnlineCourses.AdminForms;
using OnlineCourses.Method;
using OnlineCourses.StartForms;
using OnlineCourses.StudentForms;
using OnlineCourses.TeacherForms;
using OnlineCourses.UserFolder;

namespace OnlineCourses
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAuthorise_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text.Equals("admin") || tbPassword.Text.Equals("admin"))
            {
                new AdminMainForm().Show();
            }
            else 
            if (CoursesMethod.IsAuthenticated(tbLogin.Text, tbPassword.Text))
            {
                string role = CoursesMethod.GetRole(tbLogin.Text);
                if (role == "student")
                {
                    new StudentMainForm(CoursesMethod.GetId(tbLogin.Text)).Show();
                }
                else if (role == "teacher")
                {
                    new TeacherMainForm(CoursesMethod.GetId(tbLogin.Text)).Show();
                }
                else MessageBox.Show("ERROR");
                        
            }
            else labelAlert.Text = "Не вірний логін/пароль";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            new RegisterForm().Show();
        }
    }
}