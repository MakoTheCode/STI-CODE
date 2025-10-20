namespace StudentInfoApplication
{
    partial class frmStudentInfo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStudentIDList = new System.Windows.Forms.Label();
            this.lblFirstNameList = new System.Windows.Forms.Label();
            this.lblLastNameList = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbStudentID = new System.Windows.Forms.ListBox();
            this.lbLastName = new System.Windows.Forms.ListBox();
            this.lbFirstName = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label Initializations
            // 
            InitLabel(this.lblStudentID, "Student ID *", 25, 25);
            InitLabel(this.lblLastName, "Last name *", 275, 25);
            InitLabel(this.lblFirstName, "First name *", 525, 25);
            InitLabel(this.lblStudentIDList, "Student ID List *", 25, 150);
            InitLabel(this.lblFirstNameList, "First Name List *", 525, 150);
            InitLabel(this.lblLastNameList, "Last Name List *", 275, 150);
            // 
            // TextBox Initializations
            // 
            InitTextBox(this.txtStudentID, 20, 65);
            InitTextBox(this.txtLastName, 270, 65);
            InitTextBox(this.txtFirstName, 520, 65);
            // 
            // ListBox Initializations
            // 
            InitListBox(this.lbStudentID, 20, 190);
            InitListBox(this.lbLastName, 270, 190);
            InitListBox(this.lbFirstName, 520, 190);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(650, 100);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblLastNameList);
            this.Controls.Add(this.lblFirstNameList);
            this.Controls.Add(this.lblStudentIDList);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "frmStudentInfo";
            this.Text = "Student Info";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void InitLabel(System.Windows.Forms.Label label, string text, int x, int y)
        {
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label.Location = new System.Drawing.Point(x, y);
            label.Name = "label";
            label.Size = new System.Drawing.Size(117, 25);
            label.TabIndex = 0;
            label.Text = text;
        }

        private void InitTextBox(System.Windows.Forms.TextBox textBox, int x, int y)
        {
            textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            textBox.Location = new System.Drawing.Point(x, y);
            textBox.Name = "textBox";
            textBox.Size = new System.Drawing.Size(240, 30);
            textBox.TabIndex = 6;
        }

        private void InitListBox(System.Windows.Forms.ListBox listBox, int x, int y)
        {
            listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 25;
            listBox.Location = new System.Drawing.Point(x, y);
            listBox.Name = "listBox";
            listBox.Size = new System.Drawing.Size(240, 229);
            listBox.TabIndex = 9;
        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStudentIDList;
        private System.Windows.Forms.Label lblFirstNameList;
        private System.Windows.Forms.Label lblLastNameList;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ListBox lbStudentID;
        private System.Windows.Forms.ListBox lbLastName;
        private System.Windows.Forms.ListBox lbFirstName;
        private System.Windows.Forms.Button btnSubmit;
    }
}
