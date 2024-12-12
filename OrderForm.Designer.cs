namespace CoffeeShopManagement
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox comboBoxCustomers;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnLoadOrders;
        private System.Windows.Forms.DataGridView dataGridViewOrders;

        private void InitializeComponent()
        {
            comboBoxCustomers = new ComboBox();
            comboBoxProducts = new ComboBox();
            txtQuantity = new TextBox();
            btnAddOrder = new Button();
            btnLoadOrders = new Button();
            dataGridViewOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCustomers
            // 
            comboBoxCustomers.Location = new Point(15, 25);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.Size = new Size(200, 33);
            comboBoxCustomers.TabIndex = 0;
            comboBoxCustomers.Visible = false;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.Location = new Point(15, 60);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(200, 33);
            comboBoxProducts.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(15, 95);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 31);
            txtQuantity.TabIndex = 2;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(15, 130);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(100, 30);
            btnAddOrder.TabIndex = 3;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnLoadOrders
            // 
            btnLoadOrders.Location = new Point(120, 130);
            btnLoadOrders.Name = "btnLoadOrders";
            btnLoadOrders.Size = new Size(100, 30);
            btnLoadOrders.TabIndex = 4;
            btnLoadOrders.Text = "Load Orders";
            btnLoadOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(15, 170);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(400, 150);
            dataGridViewOrders.TabIndex = 5;
            // 
            // OrderForm
            // 
            ClientSize = new Size(450, 350);
            Controls.Add(comboBoxCustomers);
            Controls.Add(comboBoxProducts);
            Controls.Add(txtQuantity);
            Controls.Add(btnAddOrder);
            Controls.Add(btnLoadOrders);
            Controls.Add(dataGridViewOrders);
            Name = "OrderForm";
            Text = "Order Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
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

    }
}