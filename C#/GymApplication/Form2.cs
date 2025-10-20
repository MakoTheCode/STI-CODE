using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymApplication
{
    public partial class Form2 : Form
    {
        // Declare the controls for the sliding menu and button
        private GunaPanel menuPanel;
        private GunaButton menuButton;

        public Form2()
        {
            InitializeComponent();  // Initializes components from the designer
            SetupMenu();            // Sets up the sliding menu after initializing the form
        }

        private void SetupMenu()
        {
            // Create the sliding menu panel
            menuPanel = new GunaPanel();
            menuPanel.Size = new Size(200, this.ClientSize.Height);  // Set menu size (200px wide)
            menuPanel.Location = new Point(-200, 0);  // Initially hide the menu off-screen
            menuPanel.BackColor = Color.DarkGray;  // Set the background color for the menu

            this.Controls.Add(menuPanel);  // Add the menu panel to the form's controls

            // Create the hamburger button (three lines)
            menuButton = new GunaButton();
            menuButton.Text = "☰";  // Hamburger icon (three lines)
            menuButton.Size = new Size(50, 50);  // Size of the button
            menuButton.Location = new Point(10, 10);  // Position the button at the top-left corner
            menuButton.Click += MenuButton_Click;  // Attach the event handler for the button click

            this.Controls.Add(menuButton);  // Add the button to the form's controls
        }

        // Event handler for toggling the sliding menu
        private void MenuButton_Click(object sender, EventArgs e)
        {
            // Check if the menu is already visible
            if (menuPanel.Location.X == 0)
            {
                // If the menu is visible, slide it out of view (to the left)
                menuPanel.Location = new Point(-200, 0);
            }
            else
            {
                // If the menu is hidden, slide it into view (from the left)
                menuPanel.Location = new Point(0, 0);
            }
        }
    }
}
