namespace CoffeeShopManagement
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.ComboBox comboBoxCustomers;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnLoadOrders; 
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dataGridViewOrders;

        private void InitializeComponent()
        {
            comboBoxCustomers = new ComboBox();
            comboBoxProducts = new ComboBox();
            txtQuantity = new TextBox();
            btnAddOrder = new Button();
            btnLoadOrders = new Button();
            btnNext = new Button();
            dataGridViewOrders = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCustomers
            // 
            comboBoxCustomers.Location = new Point(17, 184);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.Size = new Size(200, 33);
            comboBoxCustomers.TabIndex = 0;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.Location = new Point(15, 54);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(200, 33);
            comboBoxProducts.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(15, 118);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 31);
            txtQuantity.TabIndex = 2;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(13, 297);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(100, 38);
            btnAddOrder.TabIndex = 3;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnLoadOrders
            // 
            btnLoadOrders.Location = new Point(119, 297);
            btnLoadOrders.Name = "btnLoadOrders";
            btnLoadOrders.Size = new Size(100, 38);
            btnLoadOrders.TabIndex = 4;
            btnLoadOrders.Text = "Load Orders";
            btnLoadOrders.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(65, 351);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(97, 44);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(229, 68);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(809, 342);
            dataGridViewOrders.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 26);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 6;
            label2.Text = "Product Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 90);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 7;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 156);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 8;
            label4.Text = "Select Customer";
            // 
            // button1
            // 
            button1.Location = new Point(229, 20);
            button1.Name = "button1";
            button1.Size = new Size(202, 40);
            button1.TabIndex = 9;
            button1.Text = "Add New Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(874, 20);
            button2.Name = "button2";
            button2.Size = new Size(164, 40);
            button2.TabIndex = 10;
            button2.Text = "Add Products";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(666, 21);
            button3.Name = "button3";
            button3.Size = new Size(193, 39);
            button3.TabIndex = 11;
            button3.Text = "Check Order Items";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // OrderForm
            // 
            ClientSize = new Size(1050, 422);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridViewOrders);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(comboBoxCustomers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNext);
            Controls.Add(comboBoxProducts);
            Controls.Add(txtQuantity);
            Controls.Add(btnAddOrder);
            Controls.Add(btnLoadOrders);
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

        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}