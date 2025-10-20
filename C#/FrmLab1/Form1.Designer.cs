namespace TextFileCreatorApp
{
    partial class FrmLab1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCreate;

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
            txtInput = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(34, 21);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(251, 103);
            txtInput.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(34, 143);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(260, 23);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create File";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmLab1
            // 
            ClientSize = new Size(332, 178);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Name = "FrmLab1";
            Text = "FrmLab1";
            Load += FrmLab1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
