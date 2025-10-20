using ItemNamespace;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem item;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItem.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrEmpty(txtDiscount.Text))
            {
                MessageBox.Show("Please fill in all the item details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            item = new DiscountedItem(txtItem.Text, double.Parse(txtPrice.Text), int.Parse(txtQuantity.Text), double.Parse(txtDiscount.Text));
            lblTotalAmountResult.Text = item.getTotalPrice().ToString("F2");

            if (item.IsFree())
            {
                MessageBox.Show("The item is free due to 100% discount. No payment is needed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblChangeResult.Text = "0.00";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                MessageBox.Show("Please calculate the total amount first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (item.IsFree())
            {
                lblChangeResult.Text = "0.00";
                return;
            }

            if (string.IsNullOrEmpty(txtPaymentReceived.Text))
            {
                MessageBox.Show("Please enter your payment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double paymentReceived;
            if (!double.TryParse(txtPaymentReceived.Text, out paymentReceived))
            {
                MessageBox.Show("Please enter a valid payment amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (paymentReceived == 0)
            {
                MessageBox.Show("Payment amount cannot be zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (paymentReceived == 1)
            {
                MessageBox.Show("Payment amount cannot be 1.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            item.setPayment(paymentReceived);

            if (item.getChange() < 0)
            {
                MessageBox.Show("Insufficient payment. The payment amount is less than the total price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblChangeResult.Text = "N/A";
            }
            else
            {
                lblChangeResult.Text = item.getChange().ToString("F2");
            }
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
