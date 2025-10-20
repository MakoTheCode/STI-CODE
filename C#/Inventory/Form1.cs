using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Added for SQL connection
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private BindingSource showProductList;

        public frmAddProduct()
        {
            InitializeComponent();

            showProductList = new BindingSource();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = new string[]
            {
                "Beverages", "Bread/Bakery", "Canned/Jarred Goods", "Dairy", "Frozen Foods", "Meat", "Personal Care", "Other"
            };

            foreach (string lopc in ListOfProductCategory)
            {
                cbCategory.Items.Add(lopc);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = Product_Name(txtProductName.Text);
                string category = cbCategory.Text;
                string mfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                string expDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                int quantity = Quantity(txtQuantity.Text);
                double sellPrice = SellingPrice(txtSellPrice.Text);
                string description = richTxtDescription.Text;

                // Create product object
                ProductClass product = new ProductClass(productName, category, mfgDate, expDate, sellPrice, quantity, description);

                // Add product to database
                AddProductToDatabase(product);

                // Optionally, add product to DataGridView
                showProductList.Add(product);
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Validation methods
        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                throw new StringFormatException("Not valid string");
            return name;
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]+$")) // Corrected regex
                throw new NumberFormatException("Not valid number");
            return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price, @"^(\d*\.)?\d+$")) // Corrected regex
                throw new CurrencyFormatException("Not valid currency");
            return Convert.ToDouble(price);
        }

        // SQL Connection method
        private SqlConnection GetSqlConnection()
        {
            // Connection string with Windows Authentication
            string connectionString = "Data Source=MARK-PC1\\SQLEXPRESS;Initial Catalog=Oliver;Integrated Security=True";
            // Create a new SqlConnection object
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        // Method to add product to database
        private void AddProductToDatabase(ProductClass product)
        {
            // Create the SQL connection
            using (SqlConnection connection = GetSqlConnection())
            {
                // Open the connection
                connection.Open();

                // SQL command to insert data
                string sql = "INSERT INTO Products (ProductName, Category, ManufacturingDate, ExpirationDate, Price, Quantity, Description) " +
                             "VALUES (@ProductName, @Category, @ManufacturingDate, @ExpirationDate, @Price, @Quantity, @Description)";

                // Create the SQL command
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@ProductName", product.productName);
                    command.Parameters.AddWithValue("@Category", product.category);
                    command.Parameters.AddWithValue("@ManufacturingDate", product.manufacturingDate);
                    command.Parameters.AddWithValue("@ExpirationDate", product.expirationDate);
                    command.Parameters.AddWithValue("@Price", product.sellingPrice);
                    command.Parameters.AddWithValue("@Quantity", product.quantity);
                    command.Parameters.AddWithValue("@Description", product.description);

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    // Product class
    internal class ProductClass
    {
        public string productName { get; set; }
        public string category { get; set; }
        public string manufacturingDate { get; set; }
        public string expirationDate { get; set; }
        public double sellingPrice { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }

        public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate,
                            double Price, int Quantity, string Description)
        {
            this.productName = ProductName;
            this.category = Category;
            this.manufacturingDate = MfgDate;
            this.expirationDate = ExpDate;
            this.sellingPrice = Price;
            this.quantity = Quantity;
            this.description = Description;
        }
    }

    // Custom exceptions
    class NumberFormatException : Exception
    {
        public NumberFormatException(string message) : base(message) { }
    }

    class StringFormatException : Exception
    {
        public StringFormatException(string message) : base(message) { }
    }

    class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string message) : base(message) { }
    }
}
