namespace OnlineCourses.TeacherForms
{
    partial class StudentDetails
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
            label6 = new Label();
            tbSurname = new TextBox();
            label7 = new Label();
            tbName = new TextBox();
            label3 = new Label();
            tbEmail = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 44);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 41;
            label6.Text = "Прізвище";
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(76, 41);
            tbSurname.Name = "tbSurname";
            tbSurname.ReadOnly = true;
            tbSurname.Size = new Size(188, 23);
            tbSurname.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 15);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 39;
            label7.Text = "Ім'я";
            // 
            // tbName
            // 
            tbName.Location = new Point(76, 12);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(188, 23);
            tbName.TabIndex = 38;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 73);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 37;
            label3.Text = "EMail";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(76, 70);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(188, 23);
            tbEmail.TabIndex = 36;
            // 
            // StudentDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 106);
            Controls.Add(label6);
            Controls.Add(tbSurname);
            Controls.Add(label7);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Name = "StudentDetails";
            Text = "StudentDetails";
            Load += StudentDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox tbSurname;
        private Label label7;
        private TextBox tbName;
        private Label label3;
        private TextBox tbEmail;
    }
}