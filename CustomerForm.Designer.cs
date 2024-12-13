namespace CoffeeShopManagement
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;

        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnAdd = new Button();
            btnLoad = new Button();
            dataGridViewCustomers = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            back_button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(15, 53);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(220, 31);
            txtFirstName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(17, 227);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(218, 31);
            txtPhone.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 316);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 37);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(130, 316);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(102, 37);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load Customers";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(255, 53);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.Size = new Size(858, 320);
            dataGridViewCustomers.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 7;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 100);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 189);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 10;
            label4.Text = "Mobile";
            // 
            // back_button1
            // 
            back_button1.Location = new Point(960, 12);
            back_button1.Name = "back_button1";
            back_button1.Size = new Size(145, 34);
            back_button1.TabIndex = 11;
            back_button1.Text = "Back to Order";
            back_button1.UseVisualStyleBackColor = true;
            back_button1.Click += back_button1_Click;
            // 
            // CustomerForm
            // 
            ClientSize = new Size(1117, 380);
            Controls.Add(back_button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(dataGridViewCustomers);
            Name = "CustomerForm";
            Text = "Customer Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label3;
        private Label label4;
        private Button back_button1;
    }
}