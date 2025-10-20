namespace BasicThreadApp
{
    partial class FrmBasicThread
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblStatus;

        // Clean up any resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Required method for Designer support
        private void InitializeComponent()
        {
            btnRun = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 12F);
            btnRun.Location = new Point(119, 166);
            btnRun.Margin = new Padding(4, 3, 4, 3);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(88, 27);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(119, 77);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(90, 30);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Thread Status";
            lblStatus.Click += lblStatus_Click;
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 205);
            Controls.Add(lblStatus);
            Controls.Add(btnRun);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmBasicThread";
            Text = "Basic Threading";
            Load += FrmBasicThread_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
