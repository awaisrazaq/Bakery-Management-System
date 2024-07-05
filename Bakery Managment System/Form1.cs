using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;


namespace Bakery_Managment_System
{
    public partial class MainForm : Form
    {
        private readonly string connectionString = "Data Source=BakeryManagementDatabase.db;Version=3;";
        public MainForm()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadProducts();
        }
        private void InitializeDatabase()
        {
            string sql = @"
-- Create Categories Table
CREATE TABLE IF NOT EXISTS Categories (
    CategoryID INTEGER PRIMARY KEY AUTOINCREMENT,
    CategoryName TEXT NOT NULL
);

-- Create Suppliers Table
CREATE TABLE IF NOT EXISTS Suppliers (
    SupplierID INTEGER PRIMARY KEY AUTOINCREMENT,
    SupplierName TEXT NOT NULL,
    ContactNumber TEXT,
    Address TEXT
);

-- Create Employees Table
CREATE TABLE IF NOT EXISTS Employees (
    EmployeeID INTEGER PRIMARY KEY AUTOINCREMENT,
    EmployeeName TEXT NOT NULL,
    JobTitle TEXT,
    ContactNumber TEXT,
    Address TEXT
);

-- Create Customers Table
CREATE TABLE IF NOT EXISTS Customers (
    CustomerID INTEGER PRIMARY KEY AUTOINCREMENT,
    CustomerName TEXT NOT NULL,
    ContactNumber TEXT,
    Address TEXT
);

-- Create Products Table
CREATE TABLE IF NOT EXISTS Products (
    ProductID INTEGER PRIMARY KEY AUTOINCREMENT,
    ProductName TEXT NOT NULL,
    CategoryID INTEGER,
    Price DECIMAL(18, 2) NOT NULL,
    Stock INTEGER NOT NULL,
    SupplierID INTEGER,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);

-- Create Orders Table
CREATE TABLE IF NOT EXISTS Orders (
    OrderID INTEGER PRIMARY KEY AUTOINCREMENT,
    CustomerID INTEGER NOT NULL,
    EmployeeID INTEGER,
    OrderDate DATETIME NOT NULL,
    TotalAmount DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Create Inventory Table
CREATE TABLE IF NOT EXISTS Inventory (
    InventoryID INTEGER PRIMARY KEY AUTOINCREMENT,
    ProductID INTEGER NOT NULL,
    StockLevel INTEGER NOT NULL,
    LastUpdated DATETIME NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Create OrderDetails Table
CREATE TABLE IF NOT EXISTS OrderDetails (
    OrderDetailID INTEGER PRIMARY KEY AUTOINCREMENT,
    OrderID INTEGER NOT NULL,
    ProductID INTEGER NOT NULL,
    Quantity INTEGER NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);



";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(sql, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LoadProducts()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            { 
                try
                {
                    connection.Open();
                    using (SQLiteDataAdapter sqlDataAdapter = new SQLiteDataAdapter("SELECT * FROM Products", connection))
                    {
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void AddProduct(string productName, int categoryID, decimal price, int stock, int supplierID)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Products (ProductName, CategoryID, Price, Stock, SupplierID) VALUES (@ProductName, @CategoryID, @Price, @Stock, @SupplierID)", connection))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void UpdateProduct(int productID, string productName, int categoryID, decimal price, int stock, int supplierID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Products SET ProductName = @ProductName, CategoryID = @CategoryID, Price = @Price, Stock = @Stock, SupplierID = @SupplierID WHERE ProductID = @ProductID", conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DeleteProduct(int productID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Products WHERE ProductID = @ProductID", conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_label_Click(object sender, EventArgs e)
        {

        }

        private void product_name_Click(object sender, EventArgs e)
        {

        }

        private void add_product_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrEmpty(productNameTextBox.Text) ||
                    !int.TryParse(categoryIDTextBox.Text, out int categoryID) ||
                    !decimal.TryParse(priceTextBox.Text, out decimal price) ||
                    !int.TryParse(stockTextBox.Text, out int stock) ||
                    !int.TryParse(supplierIDTextBox.Text, out int supplierID))
                {
                    MessageBox.Show("Please provide valid input for all fields.");
                    return;
                }

                // Add product to database
                AddProduct(productNameTextBox.Text, categoryID, price, stock, supplierID);

                // Refresh product list
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}");
            }
        }

        private void delete_product_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (!int.TryParse(productIDTextBox.Text, out int productID))
                {
                    MessageBox.Show("Please provide a valid product ID.");
                    return;
                }

                // Delete product from database
                DeleteProduct(productID);

                // Refresh product list
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}");
            }
        }

        private void update_product_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (!int.TryParse(productIDTextBox.Text, out int productID) ||
                    string.IsNullOrEmpty(productNameTextBox.Text) ||
                    !int.TryParse(categoryIDTextBox.Text, out int categoryID) ||
                    !decimal.TryParse(priceTextBox.Text, out decimal price) ||
                    !int.TryParse(stockTextBox.Text, out int stock) ||
                    !int.TryParse(supplierIDTextBox.Text, out int supplierID))
                {
                    MessageBox.Show("Please provide valid input for all fields.");
                    return;
                }

                // Update product in database
                UpdateProduct(productID, productNameTextBox.Text, categoryID, price, stock, supplierID);

                // Refresh product list
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
