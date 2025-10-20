namespace OrganizationProfile
{
    partial class FrmStudentRecord
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblStudentNo;
        private Label lblFullName;
        private Label lblProgram;
        private Label lblGender;
        private Label lblAge;
        private Label lblBirthday;
        private Label lblContactNo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblStudentNo = new Label();
            lblFullName = new Label();
            lblProgram = new Label();
            lblGender = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            lblContactNo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Microsoft Sans Serif", 12F);
            lblStudentNo.Location = new Point(122, 37);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(90, 20);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "Student No";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Microsoft Sans Serif", 12F);
            lblFullName.Location = new Point(122, 73);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(80, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Microsoft Sans Serif", 12F);
            lblProgram.Location = new Point(122, 111);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(69, 20);
            lblProgram.TabIndex = 2;
            lblProgram.Text = "Program";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft Sans Serif", 12F);
            lblGender.Location = new Point(122, 144);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(63, 20);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Microsoft Sans Serif", 12F);
            lblAge.Location = new Point(122, 182);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(38, 20);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Microsoft Sans Serif", 12F);
            lblBirthday.Location = new Point(118, 219);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(67, 20);
            lblBirthday.TabIndex = 5;
            lblBirthday.Text = "Birthday";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Microsoft Sans Serif", 12F);
            lblContactNo.Location = new Point(118, 253);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(89, 20);
            lblContactNo.TabIndex = 6;
            lblContactNo.Text = "Contact No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 7;
            label1.Text = "Student No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(26, 75);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 8;
            label2.Text = "Full Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(26, 112);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 9;
            label3.Text = "Program:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(26, 144);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 10;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(26, 182);
            label5.Name = "label5";
            label5.Size = new Size(36, 19);
            label5.TabIndex = 11;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 223);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "Birthday:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 258);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 13;
            label7.Text = "Contact No:";
            label7.Click += label7_Click;
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 328);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblContactNo);
            Controls.Add(lblBirthday);
            Controls.Add(lblAge);
            Controls.Add(lblGender);
            Controls.Add(lblProgram);
            Controls.Add(lblFullName);
            Controls.Add(lblStudentNo);
            Name = "FrmStudentRecord";
            Text = "Confirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
