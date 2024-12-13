namespace CoffeeShopManagement
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridViewProducts;

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtCategory = new TextBox();
            txtStock = new TextBox();
            btnAdd = new Button();
            btnLoad = new Button();
            dataGridViewProducts = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(15, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 31);
            txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(15, 103);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 31);
            txtPrice.TabIndex = 1;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(15, 178);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(200, 31);
            txtCategory.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(15, 252);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(200, 31);
            txtStock.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(60, 311);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 33);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(726, 7);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(208, 30);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load Products";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(226, 40);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(708, 335);
            dataGridViewProducts.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 79);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 8;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 150);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 9;
            label3.Text = "Category";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 228);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 10;
            label4.Text = "Stock";
            // 
            // ProductForm
            // 
            ClientSize = new Size(946, 380);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtStock);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(dataGridViewProducts);
            Name = "ProductForm";
            Text = "Product Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Clean up any resources being used.
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

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}