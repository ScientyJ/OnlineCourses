namespace OnlineCourses.TeacherForms
{
    partial class TeacherMainForm
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
            lbStuents = new ListBox();
            btnUpdate = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // lbCourses
            // 
            lbCourses.FormattingEnabled = true;
            lbCourses.ItemHeight = 15;
            lbCourses.Location = new Point(6, 24);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(237, 214);
            lbCourses.TabIndex = 0;
            lbCourses.SelectedIndexChanged += lbCourses_SelectedIndexChanged;
            // 
            // lbStuents
            // 
            lbStuents.FormattingEnabled = true;
            lbStuents.ItemHeight = 15;
            lbStuents.Location = new Point(249, 24);
            lbStuents.Name = "lbStuents";
            lbStuents.Size = new Size(161, 214);
            lbStuents.TabIndex = 1;
            lbStuents.SelectedIndexChanged += lbStuents_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(6, 244);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 36);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Редагувати";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(87, 244);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 3;
            button1.Text = "Видалити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(168, 244);
            button2.Name = "button2";
            button2.Size = new Size(75, 36);
            button2.TabIndex = 4;
            button2.Text = "Додати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 5;
            label1.Text = "Мої курси";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 6);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 6;
            label2.Text = "Мої ученики";
            // 
            // button3
            // 
            button3.Location = new Point(249, 244);
            button3.Name = "button3";
            button3.Size = new Size(161, 36);
            button3.TabIndex = 7;
            button3.Text = "Детальніше";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(416, 24);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(25, 256);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "ОНОВИТИ";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // TeacherMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 287);
            Controls.Add(btnRefresh);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(lbStuents);
            Controls.Add(lbCourses);
            Name = "TeacherMainForm";
            Text = "TeacherMainForm";
            Load += TeacherMainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbCourses;
        private ListBox lbStuents;
        private Button btnUpdate;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button btnRefresh;
    }
}