namespace CoffeeShopManagement
{
    partial class OrderItemsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private System.Windows.Forms.ComboBox comboBoxOrders;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Button btnLoadOrderItems;
        private System.Windows.Forms.DataGridView dataGridViewOrderItems;

        private void InitializeComponent()
        {
            comboBoxProducts = new ComboBox();
            btnLoadOrderItems = new Button();
            dataGridViewOrderItems = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            SuspendLayout();
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.Location = new Point(15, 58);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(200, 33);
            comboBoxProducts.TabIndex = 1;
            comboBoxProducts.SelectedIndexChanged += comboBoxProducts_SelectedIndexChanged;
            // 
            // btnLoadOrderItems
            // 
            btnLoadOrderItems.Location = new Point(611, 22);
            btnLoadOrderItems.Name = "btnLoadOrderItems";
            btnLoadOrderItems.Size = new Size(100, 69);
            btnLoadOrderItems.TabIndex = 4;
            btnLoadOrderItems.Text = "Reload Items";
            btnLoadOrderItems.UseVisualStyleBackColor = true;
            btnLoadOrderItems.Click += btnLoadOrderItems_Click_1;
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Location = new Point(15, 97);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.RowHeadersWidth = 51;
            dataGridViewOrderItems.Size = new Size(706, 254);
            dataGridViewOrderItems.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(307, 25);
            label1.TabIndex = 6;
            label1.Text = "Check Order Item based on Category";
            label1.Click += label1_Click;
            // 
            // OrderItemsForm
            // 
            ClientSize = new Size(733, 363);
            Controls.Add(label1);
            Controls.Add(comboBoxProducts);
            Controls.Add(btnLoadOrderItems);
            Controls.Add(dataGridViewOrderItems);
            Name = "OrderItemsForm";
            Text = "Order Item Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
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
    }
}