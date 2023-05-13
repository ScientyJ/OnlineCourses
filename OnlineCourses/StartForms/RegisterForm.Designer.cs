namespace OnlineCourses.StartForms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rbStudent = new RadioButton();
            rbTeacher = new RadioButton();
            btnRegister = new Button();
            tbLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbPassword = new TextBox();
            label3 = new Label();
            tbEmail = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            labelEMail = new Label();
            labelRole = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbSurname = new TextBox();
            label7 = new Label();
            tbName = new TextBox();
            SuspendLayout();
            // 
            // rbStudent
            // 
            rbStudent.AutoSize = true;
            rbStudent.Location = new Point(145, 168);
            rbStudent.Name = "rbStudent";
            rbStudent.Size = new Size(65, 19);
            rbStudent.TabIndex = 12;
            rbStudent.TabStop = true;
            rbStudent.Text = "Ученик";
            rbStudent.UseVisualStyleBackColor = true;
            rbStudent.CheckedChanged += rbStudent_CheckedChanged;
            // 
            // rbTeacher
            // 
            rbTeacher.AutoSize = true;
            rbTeacher.Location = new Point(224, 168);
            rbTeacher.Name = "rbTeacher";
            rbTeacher.Size = new Size(70, 19);
            rbTeacher.TabIndex = 11;
            rbTeacher.TabStop = true;
            rbTeacher.Text = "Вчитель";
            rbTeacher.UseVisualStyleBackColor = true;
            rbTeacher.CheckedChanged += rbTeacher_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(145, 193);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(119, 23);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Зареєструватися";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(124, 23);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(188, 23);
            tbLogin.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 26);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 14;
            label1.Text = "Логін";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 55);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 16;
            label2.Text = "Пароль";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(124, 52);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(188, 23);
            tbPassword.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 84);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 18;
            label3.Text = "EMail";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(124, 81);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(188, 23);
            tbEmail.TabIndex = 17;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(318, 31);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(0, 15);
            labelLogin.TabIndex = 19;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(318, 60);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(0, 15);
            labelPassword.TabIndex = 20;
            // 
            // labelEMail
            // 
            labelEMail.AutoSize = true;
            labelEMail.Location = new Point(318, 89);
            labelEMail.Name = "labelEMail";
            labelEMail.Size = new Size(0, 15);
            labelEMail.TabIndex = 21;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(300, 187);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(0, 15);
            labelRole.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 147);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(318, 118);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 142);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 26;
            label6.Text = "Прізвище";
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(124, 139);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(188, 23);
            tbSurname.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 113);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 24;
            label7.Text = "Ім'я";
            // 
            // tbName
            // 
            tbName.Location = new Point(124, 110);
            tbName.Name = "tbName";
            tbName.Size = new Size(188, 23);
            tbName.TabIndex = 23;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 224);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(tbSurname);
            Controls.Add(label7);
            Controls.Add(tbName);
            Controls.Add(labelRole);
            Controls.Add(labelEMail);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(label1);
            Controls.Add(tbLogin);
            Controls.Add(rbStudent);
            Controls.Add(rbTeacher);
            Controls.Add(btnRegister);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbStudent;
        private RadioButton rbTeacher;
        private Button btnRegister;
        private TextBox tbLogin;
        private Label label1;
        private Label label2;
        private TextBox tbPassword;
        private Label label3;
        private TextBox tbEmail;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelEMail;
        private Label labelRole;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbSurname;
        private Label label7;
        private TextBox tbName;
    }
}