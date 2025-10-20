namespace BasicCalculator
{
    partial class FrmBasicCalculator
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private ComboBox cmbOperation;
        private Button btnCalculate;
        private Label lblResult;
        private Panel pnlOutputArea; // Panel for output area

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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            cmbOperation = new ComboBox();
            btnCalculate = new Button();
            lblResult = new Label();
            pnlOutputArea = new Panel();
            pnlOutputArea.SuspendLayout();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.BackColor = SystemColors.Window;
            txtNum1.BorderStyle = BorderStyle.FixedSingle;
            txtNum1.ForeColor = Color.Black;
            txtNum1.Location = new Point(45, 37);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(220, 23);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.BackColor = SystemColors.Window;
            txtNum2.BorderStyle = BorderStyle.FixedSingle;
            txtNum2.ForeColor = Color.Black;
            txtNum2.Location = new Point(45, 132);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(220, 23);
            txtNum2.TabIndex = 1;
            // 
            // cmbOperation
            // 
            cmbOperation.BackColor = SystemColors.Window;
            cmbOperation.ForeColor = Color.Black;
            cmbOperation.FormattingEnabled = true;
            cmbOperation.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperation.Location = new Point(130, 83);
            cmbOperation.Name = "cmbOperation";
            cmbOperation.Size = new Size(57, 24);
            cmbOperation.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.Control;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.ForeColor = Color.Black;
            btnCalculate.Location = new Point(109, 186);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(96, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.Lime;
            lblResult.Location = new Point(10, 15);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(120, 17);
            lblResult.TabIndex = 4;
            lblResult.Text = "Total: 000000";
            // 
            // pnlOutputArea
            // 
            pnlOutputArea.BackColor = Color.Black;
            pnlOutputArea.BorderStyle = BorderStyle.FixedSingle;
            pnlOutputArea.Controls.Add(lblResult);
            pnlOutputArea.Location = new Point(45, 234);
            pnlOutputArea.Name = "pnlOutputArea";
            pnlOutputArea.Size = new Size(220, 50);
            pnlOutputArea.TabIndex = 0;
            // 
            // FrmBasicCalculator
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(316, 315);
            Controls.Add(pnlOutputArea);
            Controls.Add(btnCalculate);
            Controls.Add(cmbOperation);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Font = new Font("Courier New", 10F);
            ForeColor = Color.Black;
            Name = "FrmBasicCalculator";
            Text = "FrmBasicCalculator";
            pnlOutputArea.ResumeLayout(false);
            pnlOutputArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
