namespace OnlineCourses.StudentForms
{
    partial class TeacherInfo
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbSurname = new TextBox();
            label7 = new Label();
            tbName = new TextBox();
            labelEMail = new Label();
            label3 = new Label();
            tbEmail = new TextBox();
            lbCourses = new ListBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 95);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 66);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 66);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 35;
            label6.Text = "Прізвище";
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(75, 63);
            tbSurname.Name = "tbSurname";
            tbSurname.ReadOnly = true;
            tbSurname.Size = new Size(188, 23);
            tbSurname.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 37);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 33;
            label7.Text = "Ім'я";
            // 
            // tbName
            // 
            tbName.Location = new Point(75, 34);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(188, 23);
            tbName.TabIndex = 32;
            // 
            // labelEMail
            // 
            labelEMail.AutoSize = true;
            labelEMail.Location = new Point(263, 37);
            labelEMail.Name = "labelEMail";
            labelEMail.Size = new Size(0, 15);
            labelEMail.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 95);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 30;
            label3.Text = "EMail";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(75, 92);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(188, 23);
            tbEmail.TabIndex = 29;
            // 
            // lbCourses
            // 
            lbCourses.FormattingEnabled = true;
            lbCourses.ItemHeight = 15;
            lbCourses.Location = new Point(269, 34);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(240, 94);
            lbCourses.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 39;
            label1.Text = "Курси вчителя";
            // 
            // button1
            // 
            button1.Location = new Point(269, 131);
            button1.Name = "button1";
            button1.Size = new Size(240, 29);
            button1.TabIndex = 40;
            button1.Text = "Інфо";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TeacherInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 166);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lbCourses);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(tbSurname);
            Controls.Add(label7);
            Controls.Add(tbName);
            Controls.Add(labelEMail);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Name = "TeacherInfo";
            Text = "TeacherInfo";
            Load += TeacherInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbSurname;
        private Label label7;
        private TextBox tbName;
        private Label labelEMail;
        private Label label3;
        private TextBox tbEmail;
        private ListBox lbCourses;
        private Label label1;
        private Button button1;
    }
}