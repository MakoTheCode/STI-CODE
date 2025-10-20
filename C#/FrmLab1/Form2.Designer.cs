namespace TextFileCreatorApp
{
    partial class FrmFileName
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOkay;

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
            txtFileName = new TextBox();
            btnOkay = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(12, 57);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(260, 23);
            txtFileName.TabIndex = 0;
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(83, 126);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(102, 23);
            btnOkay.TabIndex = 1;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter File Name";
            label1.Click += label1_Click;
            // 
            // FrmFileName
            // 
            ClientSize = new Size(292, 193);
            Controls.Add(label1);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Name = "FrmFileName";
            Text = "frmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
