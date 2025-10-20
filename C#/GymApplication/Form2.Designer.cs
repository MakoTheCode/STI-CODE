namespace GymApplication
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        // Method to clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Automatically generated method to initialize form components
        private void InitializeComponent()
        {
            this.SuspendLayout();

            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);  // Size of the form
            this.Name = "Form2";  // Name of the form
            this.Text = "Form2";  // Title of the form

            // Background Color (Set to white or any color to match login design)
            this.BackColor = System.Drawing.Color.White;

            // Add a Panel to simulate the structure of a login form (for aesthetics)
            Guna.UI.WinForms.GunaPanel topPanel = new Guna.UI.WinForms.GunaPanel();
            topPanel.Size = new System.Drawing.Size(800, 100);  // A top panel for the header
            topPanel.Location = new System.Drawing.Point(0, 0);
            topPanel.BackColor = System.Drawing.Color.DodgerBlue;  // Blue header color
            this.Controls.Add(topPanel);

            // Add a Label in the panel (e.g., for the title or logo)
            Guna.UI.WinForms.GunaLabel titleLabel = new Guna.UI.WinForms.GunaLabel(); // Correct the placement
            titleLabel.Text = "Welcome to Progress Gym";
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            titleLabel.Location = new System.Drawing.Point(50, 30);  // Position the label within the panel
            titleLabel.AutoSize = true;
            topPanel.Controls.Add(titleLabel);  // Add the label to the top panel

            // Add a Button to open the menu (corrected the button creation)
            Guna.UI.WinForms.GunaButton actionButton = new Guna.UI.WinForms.GunaButton(); // Fixed the GunaButton initialization
            actionButton.Text = "Open Menu";
            actionButton.Size = new System.Drawing.Size(200, 40);  // Size of the button
            actionButton.Location = new System.Drawing.Point(300, 250);  // Position the button on the form
            actionButton.BaseColor = System.Drawing.Color.DodgerBlue;
            actionButton.ForeColor = System.Drawing.Color.White;
            this.Controls.Add(actionButton);  // Add the action button to the form

            // Panel and Buttons added to simulate login design style
            // No text boxes are included, just basic UI elements

            this.ResumeLayout(false);  // Finalize layout
        }
    }
}
