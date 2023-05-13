namespace OnlineCourses.StudentForms
{
    partial class MyCourses
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
            btnInfo = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // lbCourses
            // 
            lbCourses.FormattingEnabled = true;
            lbCourses.ItemHeight = 15;
            lbCourses.Location = new Point(12, 12);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(179, 259);
            lbCourses.TabIndex = 0;
            lbCourses.SelectedIndexChanged += lbCourses_SelectedIndexChanged;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(197, 12);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(137, 42);
            btnInfo.TabIndex = 1;
            btnInfo.Text = "Інфо";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(197, 60);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(137, 42);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Відписатися";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // MyCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 275);
            Controls.Add(btnRemove);
            Controls.Add(btnInfo);
            Controls.Add(lbCourses);
            Name = "MyCourses";
            Text = "MyCourses";
            Load += MyCourses_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbCourses;
        private Button btnInfo;
        private Button btnRemove;
    }
}