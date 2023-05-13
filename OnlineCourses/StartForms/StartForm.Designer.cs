namespace OnlineCourses
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelLoginAlert = new Label();
            labelPasswordAlert = new Label();
            btnAuthorise = new Button();
            btnRegister = new Button();
            labelAlert = new Label();
            SuspendLayout();
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(191, 97);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(218, 23);
            tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(191, 126);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(218, 23);
            tbPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 100);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Логін";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 129);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // labelLoginAlert
            // 
            labelLoginAlert.AutoSize = true;
            labelLoginAlert.Location = new Point(393, 100);
            labelLoginAlert.Name = "labelLoginAlert";
            labelLoginAlert.Size = new Size(0, 15);
            labelLoginAlert.TabIndex = 4;
            // 
            // labelPasswordAlert
            // 
            labelPasswordAlert.AutoSize = true;
            labelPasswordAlert.Location = new Point(393, 129);
            labelPasswordAlert.Name = "labelPasswordAlert";
            labelPasswordAlert.Size = new Size(0, 15);
            labelPasswordAlert.TabIndex = 5;
            // 
            // btnAuthorise
            // 
            btnAuthorise.Location = new Point(191, 155);
            btnAuthorise.Name = "btnAuthorise";
            btnAuthorise.Size = new Size(93, 23);
            btnAuthorise.TabIndex = 6;
            btnAuthorise.Text = "Увійти";
            btnAuthorise.UseVisualStyleBackColor = true;
            btnAuthorise.Click += btnAuthorise_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(290, 155);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(119, 23);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Зареєструватися";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // labelAlert
            // 
            labelAlert.AutoSize = true;
            labelAlert.ForeColor = Color.Red;
            labelAlert.Location = new Point(226, 190);
            labelAlert.Name = "labelAlert";
            labelAlert.Size = new Size(0, 15);
            labelAlert.TabIndex = 12;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(585, 282);
            Controls.Add(labelAlert);
            Controls.Add(btnRegister);
            Controls.Add(btnAuthorise);
            Controls.Add(labelPasswordAlert);
            Controls.Add(labelLoginAlert);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            Name = "StartForm";
            Text = "Form1";
            Load += StartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLogin;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Label labelLoginAlert;
        private Label labelPasswordAlert;
        private Button btnAuthorise;
        private Button btnRegister;
        private Label labelAlert;
    }
}