namespace CoffeeShopManagement
{
    partial class OrderItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxOrders;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddOrderItem;
        private System.Windows.Forms.Button btnLoadOrderItems;
        private System.Windows.Forms.DataGridView dataGridViewOrderItems;

        private void InitializeComponent()
        {
            this.comboBoxOrders = new System.Windows.Forms.ComboBox();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddOrderItem = new System.Windows.Forms.Button();
            this.btnLoadOrderItems = new System.Windows.Forms.Button();
            this.dataGridViewOrderItems = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            this.SuspendLayout();

            // 
            // comboBoxOrders  
            // 
            this.comboBoxOrders.Location = new System.Drawing.Point(15, 25);
            this.comboBoxOrders.Name = "comboBoxOrders";
            this.comboBoxOrders.Size = new System.Drawing.Size(200, 24);
            this.comboBoxOrders.TabIndex = 0;

            // 
            // comboBoxProducts  
            // 
            this.comboBoxProducts.Location = new System.Drawing.Point(15, 60);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(200, 24);
            this.comboBoxProducts.TabIndex = 1;

            // 
            // txtQuantity  
            // 
            this.txtQuantity.Location = new System.Drawing.Point(15, 95);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 2;

            // 
            // btnAddOrderItem  
            // 
            this.btnAddOrderItem.Location = new System.Drawing.Point(15, 130);
            this.btnAddOrderItem.Name = "btnAddOrderItem";
            this.btnAddOrderItem.Size = new System.Drawing.Size(100, 30);
            this.btnAddOrderItem.TabIndex = 3;
            this.btnAddOrderItem.Text = "Add Item";
            this.btnAddOrderItem.UseVisualStyleBackColor = true;

            // 
            // btnLoadOrderItems  
            // 
            this.btnLoadOrderItems.Location = new System.Drawing.Point(120, 130);
            this.btnLoadOrderItems.Name = "btnLoadOrderItems";
            this.btnLoadOrderItems.Size = new System.Drawing.Size(100, 30);
            this.btnLoadOrderItems.TabIndex = 4;
            this.btnLoadOrderItems.Text = "Load Items";
            this.btnLoadOrderItems.UseVisualStyleBackColor = true;

            // 
            // dataGridViewOrderItems  
            // 
            this.dataGridViewOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(15, 170);
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.RowHeadersWidth = 51;
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewOrderItems.TabIndex = 5;

            // 
            // OrderItemForm  
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.comboBoxOrders);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAddOrderItem);
            this.Controls.Add(this.btnLoadOrderItems);
            this.Controls.Add(this.dataGridViewOrderItems);
            this.Text = "Order Item Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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