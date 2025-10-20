using System;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        // Form controls
        private Label lblName;
        private Label lblEnglish;
        private Label lblMath;
        private Label lblScience;
        private Label lblFilipino;
        private Label lblHistory;
        private TextBox txtName;
        private TextBox txtEnglish;
        private TextBox txtMath;
        private TextBox txtScience;
        private TextBox txtFilipino;
        private TextBox txtHistory;
        private Button btnGenerateAverage;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblMath = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.lblFilipino = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.txtFilipino = new System.Windows.Forms.TextBox();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.btnGenerateAverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(9, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblEnglish
            // 
            this.lblEnglish.Location = new System.Drawing.Point(9, 50);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(52, 20);
            this.lblEnglish.TabIndex = 1;
            this.lblEnglish.Text = "English:";
            this.lblEnglish.Click += new System.EventHandler(this.lblEnglish_Click);
            // 
            // lblMath
            // 
            this.lblMath.Location = new System.Drawing.Point(9, 73);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(52, 20);
            this.lblMath.TabIndex = 2;
            this.lblMath.Text = "Math:";
            // 
            // lblScience
            // 
            this.lblScience.Location = new System.Drawing.Point(6, 99);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(52, 20);
            this.lblScience.TabIndex = 3;
            this.lblScience.Text = "Science:";
            this.lblScience.Click += new System.EventHandler(this.lblScience_Click);
            // 
            // lblFilipino
            // 
            this.lblFilipino.Location = new System.Drawing.Point(9, 124);
            this.lblFilipino.Name = "lblFilipino";
            this.lblFilipino.Size = new System.Drawing.Size(52, 20);
            this.lblFilipino.TabIndex = 4;
            this.lblFilipino.Text = "Filipino:";
            this.lblFilipino.Click += new System.EventHandler(this.lblFilipino_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.Location = new System.Drawing.Point(9, 150);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(52, 20);
            this.lblHistory.TabIndex = 5;
            this.lblHistory.Text = "History:";
            this.lblHistory.Click += new System.EventHandler(this.lblHistory_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(64, 50);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(68, 20);
            this.txtEnglish.TabIndex = 7;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(64, 73);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(68, 20);
            this.txtMath.TabIndex = 8;
            this.txtMath.TextChanged += new System.EventHandler(this.txtMath_TextChanged);
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(64, 99);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(68, 20);
            this.txtScience.TabIndex = 9;
            // 
            // txtFilipino
            // 
            this.txtFilipino.Location = new System.Drawing.Point(64, 124);
            this.txtFilipino.Name = "txtFilipino";
            this.txtFilipino.Size = new System.Drawing.Size(68, 20);
            this.txtFilipino.TabIndex = 10;
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(64, 150);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(68, 20);
            this.txtHistory.TabIndex = 11;
            // 
            // btnGenerateAverage
            // 
            this.btnGenerateAverage.Location = new System.Drawing.Point(9, 188);
            this.btnGenerateAverage.Name = "btnGenerateAverage";
            this.btnGenerateAverage.Size = new System.Drawing.Size(100, 45);
            this.btnGenerateAverage.TabIndex = 12;
            this.btnGenerateAverage.Text = "Generate Average";
            this.btnGenerateAverage.Click += new System.EventHandler(this.btnGenerateAverage_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblMath);
            this.Controls.Add(this.lblScience);
            this.Controls.Add(this.lblFilipino);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtScience);
            this.Controls.Add(this.txtFilipino);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.btnGenerateAverage);
            this.Name = "Form1";
            this.Text = "StudentGradeApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnGenerateAverage_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the student's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtEnglish.Text, out double english) ||
                !double.TryParse(txtMath.Text, out double math) ||
                !double.TryParse(txtScience.Text, out double science) ||
                !double.TryParse(txtFilipino.Text, out double filipino) ||
                !double.TryParse(txtHistory.Text, out double history))
            {
                MessageBox.Show("Please enter valid grades for all subjects.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate average grade
            double averageGrade = (english + math + science + filipino + history) / 5.0;

            // Determine pass or fail using ternary operator
            string result = averageGrade >= 75.00 ? "The student passed." : "The student failed.";

            // Display result
            // Display result on the right side
            Label lblResult = new Label();
            lblResult.AutoSize = true;
            lblResult.Location = new System.Drawing.Point(150, 100); // Adjust the location as needed
            lblResult.Text = $"The general average of {txtName.Text} is: {averageGrade:F2}\n{result}";
            this.Controls.Add(lblResult);

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblEnglish_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblScience_Click(object sender, EventArgs e)
        {

        }

        private void lblFilipino_Click(object sender, EventArgs e)
        {

        }

        private void lblHistory_Click(object sender, EventArgs e)
        {

        }

        private void txtMath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
