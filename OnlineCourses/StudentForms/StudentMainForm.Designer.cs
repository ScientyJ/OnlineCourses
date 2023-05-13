namespace OnlineCourses.StudentForms
{
    partial class StudentMainForm
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
            lbCourses = new ListBox();
            lbTeachers = new ListBox();
            btnInfo = new Button();
            btnMyCourses = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbCourses
            // 
            lbCourses.FormattingEnabled = true;
            lbCourses.ItemHeight = 15;
            lbCourses.Location = new Point(12, 22);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(162, 259);
            lbCourses.TabIndex = 0;
            lbCourses.SelectedIndexChanged += lbCourses_SelectedIndexChanged;
            // 
            // lbTeachers
            // 
            lbTeachers.FormattingEnabled = true;
            lbTeachers.ItemHeight = 15;
            lbTeachers.Location = new Point(180, 22);
            lbTeachers.Name = "lbTeachers";
            lbTeachers.Size = new Size(162, 259);
            lbTeachers.TabIndex = 1;
            lbTeachers.SelectedIndexChanged += lbTeachers_SelectedIndexChanged;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(12, 287);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(330, 31);
            btnInfo.TabIndex = 2;
            btnInfo.Text = "Інфо";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnMyCourses
            // 
            btnMyCourses.Location = new Point(348, 22);
            btnMyCourses.Name = "btnMyCourses";
            btnMyCourses.RightToLeft = RightToLeft.No;
            btnMyCourses.Size = new Size(115, 58);
            btnMyCourses.TabIndex = 3;
            btnMyCourses.Text = "Мої курси";
            btnMyCourses.UseVisualStyleBackColor = true;
            btnMyCourses.Click += btnMyCourses_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 4);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Курси";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 4);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Учителі";
            // 
            // StudentMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 322);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMyCourses);
            Controls.Add(btnInfo);
            Controls.Add(lbTeachers);
            Controls.Add(lbCourses);
            Name = "StudentMainForm";
            Text = "StudentMainForm";
            Load += StudentMainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbCourses;
        private ListBox lbTeachers;
        private Button btnInfo;
        private Button btnMyCourses;
        private Label label1;
        private Label label2;
    }
}