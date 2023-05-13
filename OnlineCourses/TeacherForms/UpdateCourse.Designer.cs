namespace OnlineCourses.TeacherForms
{
    partial class UpdateCourse
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
            labelAlert = new Label();
            btnUpdate = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tbBio = new TextBox();
            label4 = new Label();
            tbPrice = new TextBox();
            label3 = new Label();
            tbLength = new TextBox();
            label2 = new Label();
            tbSubject = new TextBox();
            label1 = new Label();
            tbName = new TextBox();
            SuspendLayout();
            // 
            // labelAlert
            // 
            labelAlert.AutoSize = true;
            labelAlert.ForeColor = Color.Red;
            labelAlert.Location = new Point(71, 276);
            labelAlert.Name = "labelAlert";
            labelAlert.Size = new Size(0, 15);
            labelAlert.TabIndex = 27;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(10, 241);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(291, 32);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Зберегти";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 101);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 25;
            label7.Text = "грн";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(193, 72);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 24;
            label6.Text = "уроків";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 130);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 23;
            label5.Text = "Опис";
            // 
            // tbBio
            // 
            tbBio.Location = new Point(106, 127);
            tbBio.Multiline = true;
            tbBio.Name = "tbBio";
            tbBio.Size = new Size(190, 108);
            tbBio.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 101);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 21;
            label4.Text = "Ціна";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(106, 98);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(96, 23);
            tbPrice.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 72);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 19;
            label3.Text = "Дожина";
            // 
            // tbLength
            // 
            tbLength.Location = new Point(106, 69);
            tbLength.Name = "tbLength";
            tbLength.Size = new Size(81, 23);
            tbLength.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 43);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 17;
            label2.Text = "Напрям";
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(106, 40);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(190, 23);
            tbSubject.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 15;
            label1.Text = "Назва";
            // 
            // tbName
            // 
            tbName.Location = new Point(106, 11);
            tbName.Name = "tbName";
            tbName.Size = new Size(190, 23);
            tbName.TabIndex = 14;
            // 
            // UpdateCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 297);
            Controls.Add(labelAlert);
            Controls.Add(btnUpdate);
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
            Name = "UpdateCourse";
            Text = "UpdateCourse";
            Load += UpdateCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAlert;
        private Button btnUpdate;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbBio;
        private Label label4;
        private TextBox tbPrice;
        private Label label3;
        private TextBox tbLength;
        private Label label2;
        private TextBox tbSubject;
        private Label label1;
        private TextBox tbName;
    }
}