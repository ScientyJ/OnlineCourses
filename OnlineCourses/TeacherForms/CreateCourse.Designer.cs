namespace OnlineCourses.TeacherForms
{
    partial class CreateCourse
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
            tbName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbSubject = new TextBox();
            label3 = new Label();
            tbLength = new TextBox();
            label4 = new Label();
            tbPrice = new TextBox();
            label5 = new Label();
            tbBio = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnCreateCourse = new Button();
            labelAlert = new Label();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(108, 12);
            tbName.Name = "tbName";
            tbName.Size = new Size(190, 23);
            tbName.TabIndex = 0;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Назва";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Напрям";
            label2.Click += label2_Click;
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(108, 41);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(190, 23);
            tbSubject.TabIndex = 2;
            tbSubject.TextChanged += tbSubject_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Дожина";
            label3.Click += label3_Click;
            // 
            // tbLength
            // 
            tbLength.Location = new Point(108, 70);
            tbLength.Name = "tbLength";
            tbLength.Size = new Size(81, 23);
            tbLength.TabIndex = 4;
            tbLength.TextChanged += tbLength_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 7;
            label4.Text = "Ціна";
            label4.Click += label4_Click;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(108, 99);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(96, 23);
            tbPrice.TabIndex = 6;
            tbPrice.TextChanged += tbPrice_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 131);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Опис";
            label5.Click += label5_Click;
            // 
            // tbBio
            // 
            tbBio.Location = new Point(108, 128);
            tbBio.Multiline = true;
            tbBio.Name = "tbBio";
            tbBio.Size = new Size(190, 108);
            tbBio.TabIndex = 8;
            tbBio.TextChanged += tbBio_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 73);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 10;
            label6.Text = "уроків";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(210, 102);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 11;
            label7.Text = "грн";
            label7.Click += label7_Click;
            // 
            // btnCreateCourse
            // 
            btnCreateCourse.Location = new Point(12, 242);
            btnCreateCourse.Name = "btnCreateCourse";
            btnCreateCourse.Size = new Size(291, 32);
            btnCreateCourse.TabIndex = 12;
            btnCreateCourse.Text = "Створити";
            btnCreateCourse.UseVisualStyleBackColor = true;
            btnCreateCourse.Click += btnCreateCourse_Click;
            // 
            // labelAlert
            // 
            labelAlert.AutoSize = true;
            labelAlert.ForeColor = Color.Red;
            labelAlert.Location = new Point(73, 277);
            labelAlert.Name = "labelAlert";
            labelAlert.Size = new Size(0, 15);
            labelAlert.TabIndex = 13;
            labelAlert.Click += labelAlert_Click;
            // 
            // CreateCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 296);
            Controls.Add(labelAlert);
            Controls.Add(btnCreateCourse);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbBio);
            Controls.Add(label4);
            Controls.Add(tbPrice);
            Controls.Add(label3);
            Controls.Add(tbLength);
            Controls.Add(label2);
            Controls.Add(tbSubject);
            Controls.Add(label1);
            Controls.Add(tbName);
            Name = "CreateCourse";
            Text = "CreateCourse";
            Load += CreateCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private Label label1;
        private Label label2;
        private TextBox tbSubject;
        private Label label3;
        private TextBox tbLength;
        private Label label4;
        private TextBox tbPrice;
        private Label label5;
        private TextBox tbBio;
        private Label label6;
        private Label label7;
        private Button btnCreateCourse;
        private Label labelAlert;
    }
}