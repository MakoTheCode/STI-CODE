namespace GymApplication
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel dragPanel;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2CheckBox chkRemember;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeader;

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            // Draggable Panel
            this.dragPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dragPanel.Size = new System.Drawing.Size(350, 40);
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.Controls.Add(this.dragPanel);

            // Header Label
            this.lblHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHeader.Text = "ProgressPass";
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(10, 5);
            this.lblHeader.AutoSize = true;
            this.dragPanel.Controls.Add(this.lblHeader);

            // Close Button
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose.Text = "X";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(310, 5);
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.dragPanel.Controls.Add(this.btnClose);

            // Minimize Button
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize.Text = "-";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.Location = new System.Drawing.Point(270, 5);
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            this.dragPanel.Controls.Add(this.btnMinimize);

            // Username TextBox
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Location = new System.Drawing.Point(50, 100);
            this.txtUsername.Size = new System.Drawing.Size(250, 40);
            this.txtUsername.BorderRadius = 10;
            this.Controls.Add(this.txtUsername);

            // Password TextBox
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Location = new System.Drawing.Point(50, 160);
            this.txtPassword.Size = new System.Drawing.Size(250, 40);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.BorderRadius = 10;
            this.Controls.Add(this.txtPassword);

            // Remember Me Checkbox
            this.chkRemember = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkRemember.Text = "Remember Me";
            this.chkRemember.ForeColor = System.Drawing.Color.White;
            this.chkRemember.Location = new System.Drawing.Point(50, 220);
            this.Controls.Add(this.chkRemember);

            // Forgot Password Link
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lnkForgotPassword.Text = "Forgot Password?";
            this.lnkForgotPassword.ForeColor = System.Drawing.Color.LightBlue;
            this.lnkForgotPassword.Location = new System.Drawing.Point(200, 220);
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.Click += new System.EventHandler(this.LnkForgotPassword_Click);
            this.Controls.Add(this.lnkForgotPassword);

            // Login Button
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin.Text = "Login";
            this.btnLogin.Size = new System.Drawing.Size(250, 40);
            this.btnLogin.Location = new System.Drawing.Point(50, 270);
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.FillColor = System.Drawing.Color.BlueViolet;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.MediumPurple;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.Controls.Add(this.btnLogin);
        }
    }
}