namespace Bakery_Managment_System
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            product_name = new Label();
            add_product = new Button();
            productNameTextBox = new TextBox();
            stockTextBox = new TextBox();
            supplierIDTextBox = new TextBox();
            priceTextBox = new TextBox();
            categoryIDTextBox = new TextBox();
            supplier_id = new Label();
            stock = new Label();
            price_label = new Label();
            category_id = new Label();
            delete_product = new Button();
            update_product = new Button();
            productIDTextBox = new TextBox();
            productID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(760, 250);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // product_name
            // 
            product_name.AutoSize = true;
            product_name.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            product_name.ForeColor = Color.FromArgb(51, 51, 51);
            product_name.Location = new Point(12, 315);
            product_name.Name = "product_name";
            product_name.Size = new Size(113, 19);
            product_name.TabIndex = 1;
            product_name.Tag = "";
            product_name.Text = "Product Name";
            product_name.Click += product_name_Click;
            // 
            // add_product
            // 
            add_product.BackColor = Color.LightBlue;
            add_product.FlatStyle = FlatStyle.Flat;
            add_product.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_product.Location = new Point(12, 398);
            add_product.Name = "add_product";
            add_product.Size = new Size(100, 30);
            add_product.TabIndex = 2;
            add_product.Text = "Add\r\n\r\n";
            add_product.UseVisualStyleBackColor = false;
            add_product.Click += add_product_Click;
            // 
            // productNameTextBox
            // 
            productNameTextBox.BackColor = Color.FromArgb(230, 230, 230);
            productNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            productNameTextBox.Location = new Point(154, 312);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(200, 27);
            productNameTextBox.TabIndex = 3;
            productNameTextBox.TextChanged += ProductName_TextChanged;
            // 
            // stockTextBox
            // 
            stockTextBox.BackColor = Color.FromArgb(230, 230, 230);
            stockTextBox.BorderStyle = BorderStyle.FixedSingle;
            stockTextBox.Location = new Point(572, 279);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(200, 27);
            stockTextBox.TabIndex = 4;
            // 
            // supplierIDTextBox
            // 
            supplierIDTextBox.BackColor = Color.FromArgb(230, 230, 230);
            supplierIDTextBox.BorderStyle = BorderStyle.FixedSingle;
            supplierIDTextBox.Location = new Point(572, 312);
            supplierIDTextBox.Name = "supplierIDTextBox";
            supplierIDTextBox.Size = new Size(200, 27);
            supplierIDTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            priceTextBox.BackColor = Color.FromArgb(230, 230, 230);
            priceTextBox.BorderStyle = BorderStyle.FixedSingle;
            priceTextBox.Location = new Point(154, 345);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(200, 27);
            priceTextBox.TabIndex = 7;
            // 
            // categoryIDTextBox
            // 
            categoryIDTextBox.BackColor = Color.FromArgb(230, 230, 230);
            categoryIDTextBox.BorderStyle = BorderStyle.FixedSingle;
            categoryIDTextBox.Location = new Point(572, 346);
            categoryIDTextBox.Name = "categoryIDTextBox";
            categoryIDTextBox.Size = new Size(200, 27);
            categoryIDTextBox.TabIndex = 8;
            // 
            // supplier_id
            // 
            supplier_id.AutoSize = true;
            supplier_id.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplier_id.ForeColor = Color.FromArgb(51, 51, 51);
            supplier_id.Location = new Point(453, 320);
            supplier_id.Name = "supplier_id";
            supplier_id.Size = new Size(91, 19);
            supplier_id.TabIndex = 9;
            supplier_id.Tag = "";
            supplier_id.Text = "Supplier ID";
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stock.ForeColor = Color.FromArgb(51, 51, 51);
            stock.Location = new Point(453, 287);
            stock.Name = "stock";
            stock.Size = new Size(50, 19);
            stock.TabIndex = 10;
            stock.Tag = "";
            stock.Text = "Stock";
            // 
            // price_label
            // 
            price_label.AutoSize = true;
            price_label.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price_label.ForeColor = Color.FromArgb(51, 51, 51);
            price_label.Location = new Point(12, 348);
            price_label.Name = "price_label";
            price_label.Size = new Size(48, 19);
            price_label.TabIndex = 11;
            price_label.Tag = "";
            price_label.Text = "Price";
            price_label.Click += price_label_Click;
            // 
            // category_id
            // 
            category_id.AutoSize = true;
            category_id.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_id.ForeColor = Color.FromArgb(51, 51, 51);
            category_id.Location = new Point(453, 354);
            category_id.Name = "category_id";
            category_id.Size = new Size(98, 19);
            category_id.TabIndex = 12;
            category_id.Tag = "";
            category_id.Text = "Category ID";
            // 
            // delete_product
            // 
            delete_product.BackColor = Color.LightBlue;
            delete_product.FlatStyle = FlatStyle.Flat;
            delete_product.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_product.Location = new Point(672, 398);
            delete_product.Name = "delete_product";
            delete_product.Size = new Size(100, 30);
            delete_product.TabIndex = 13;
            delete_product.Text = "Delete";
            delete_product.UseVisualStyleBackColor = false;
            delete_product.Click += delete_product_Click;
            // 
            // update_product
            // 
            update_product.BackColor = Color.LightBlue;
            update_product.FlatStyle = FlatStyle.Flat;
            update_product.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_product.Location = new Point(343, 398);
            update_product.Name = "update_product";
            update_product.Size = new Size(100, 30);
            update_product.TabIndex = 14;
            update_product.Text = "Update";
            update_product.UseVisualStyleBackColor = false;
            update_product.Click += update_product_Click;
            // 
            // productIDTextBox
            // 
            productIDTextBox.BackColor = Color.FromArgb(230, 230, 230);
            productIDTextBox.BorderStyle = BorderStyle.FixedSingle;
            productIDTextBox.Location = new Point(154, 279);
            productIDTextBox.Name = "productIDTextBox";
            productIDTextBox.Size = new Size(200, 27);
            productIDTextBox.TabIndex = 15;
            productIDTextBox.TextChanged += textBox1_TextChanged;
            // 
            // productID
            // 
            productID.AutoSize = true;
            productID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productID.ForeColor = Color.FromArgb(51, 51, 51);
            productID.Location = new Point(12, 287);
            productID.Name = "productID";
            productID.Size = new Size(88, 19);
            productID.TabIndex = 16;
            productID.Tag = "";
            productID.Text = "Product ID";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(782, 444);
            Controls.Add(productID);
            Controls.Add(productIDTextBox);
            Controls.Add(update_product);
            Controls.Add(delete_product);
            Controls.Add(category_id);
            Controls.Add(price_label);
            Controls.Add(stock);
            Controls.Add(supplier_id);
            Controls.Add(categoryIDTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(supplierIDTextBox);
            Controls.Add(stockTextBox);
            Controls.Add(productNameTextBox);
            Controls.Add(add_product);
            Controls.Add(product_name);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label product_name;
        private Button add_product;
        private TextBox productNameTextBox;
        private TextBox stockTextBox;
        private TextBox supplierIDTextBox;
        private TextBox priceTextBox;
        private TextBox categoryIDTextBox;
        private Label supplier_id;
        private Label stock;
        private Label price_label;
        private Label category_id;
        private Button delete_product;
        private Button update_product;
        private TextBox productIDTextBox;
        private Label productID;
    }
}
