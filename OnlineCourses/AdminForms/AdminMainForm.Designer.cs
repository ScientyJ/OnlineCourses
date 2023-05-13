namespace OnlineCourses.AdminForms
{
    partial class AdminMainForm
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
            lbTeachers = new ListBox();
            lbStudents = new ListBox();
            lbCourses = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRemoveUser = new Button();
            btnRemoveCourse = new Button();
            SuspendLayout();
            // 
            // lbTeachers
            // 
            lbTeachers.FormattingEnabled = true;
            lbTeachers.ItemHeight = 15;
            lbTeachers.Location = new Point(11, 26);
            lbTeachers.Name = "lbTeachers";
            lbTeachers.Size = new Size(158, 319);
            lbTeachers.TabIndex = 0;
            lbTeachers.SelectedIndexChanged += lbTeachers_SelectedIndexChanged;
            // 
            // lbStudents
            // 
            lbStudents.FormattingEnabled = true;
            lbStudents.ItemHeight = 15;
            lbStudents.Location = new Point(175, 26);
            lbStudents.Name = "lbStudents";
            lbStudents.Size = new Size(158, 319);
            lbStudents.TabIndex = 1;
            lbStudents.SelectedIndexChanged += lbStudents_SelectedIndexChanged;
            // 
            // lbCourses
            // 
            lbCourses.FormattingEnabled = true;
            lbCourses.ItemHeight = 15;
            lbCourses.Location = new Point(339, 26);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(158, 319);
            lbCourses.TabIndex = 2;
            lbCourses.SelectedIndexChanged += lbCourses_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Учителі";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 9);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Учні";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 9);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Курси";
            // 
            // btnRemoveUser
            // 
            btnRemoveUser.ForeColor = Color.Red;
            btnRemoveUser.Location = new Point(11, 351);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Size = new Size(322, 23);
            btnRemoveUser.TabIndex = 6;
            btnRemoveUser.Text = "Remove";
            btnRemoveUser.UseVisualStyleBackColor = true;
            btnRemoveUser.Click += btnRemoveUser_Click;
            // 
            // btnRemoveCourse
            // 
            btnRemoveCourse.ForeColor = Color.Red;
            btnRemoveCourse.Location = new Point(339, 351);
            btnRemoveCourse.Name = "btnRemoveCourse";
            btnRemoveCourse.Size = new Size(158, 23);
            btnRemoveCourse.TabIndex = 7;
            btnRemoveCourse.Text = "Remove";
            btnRemoveCourse.UseVisualStyleBackColor = true;
            btnRemoveCourse.Click += btnRemoveCourse_Click;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 381);
            Controls.Add(btnRemoveCourse);
            Controls.Add(btnRemoveUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbCourses);
            Controls.Add(lbStudents);
            Controls.Add(lbTeachers);
            Name = "AdminMainForm";
            Text = "AdminMainForm";
            Load += AdminMainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbTeachers;
        private ListBox lbStudents;
        private ListBox lbCourses;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRemoveUser;
        private Button btnRemoveCourse;
    }
}