using CoffeeShopManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class OrderItemsForm : Form
    {
        public OrderItemsForm()
        {
            InitializeComponent();

            LoadProducts();
            btnLoadOrderItems.Click += BtnLoadOrderItems_Click;
        }

        private void LoadProducts()
        {
            using (var context = new CoffeeShopContext())
            {
                var products = context.Products.ToList();
                comboBoxProducts.DataSource = products;
                comboBoxProducts.DisplayMember = "Name"; // Display the product name  
                comboBoxProducts.ValueMember = "ProductId";
            }
        }
        private void BtnLoadOrderItems_Click(object sender, EventArgs e)
        {
            using (var context = new CoffeeShopContext())
            {
                var orderItems = context.OrderItems.Select(oi => new
                {
                    oi.OrderItemID,
                    ProductName = oi.Product.Name,
                    oi.Quantity,
                }).ToList();

                dataGridViewOrderItems.DataSource = orderItems;
            }
        }

        private void ClearFields()
        {
            comboBoxProducts.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadOrderItems_Click_1(object sender, EventArgs e)
        {
            using (var context = new CoffeeShopContext())
            {
                var orderItems = context.OrderItems.Select(oi => new
                {
                    oi.OrderItemID,
                    ProductName = oi.Product.Name,
                    oi.Quantity,
                }).ToList();

                dataGridViewOrderItems.DataSource = orderItems;
            }
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new CoffeeShopContext())
            {
                var orderItems = context.OrderItems.Where(m=>m.Product.Name == comboBoxProducts.Text).Select(oi => new
                {
                    oi.OrderItemID,
                    ProductName = oi.Product.Name,
                    oi.Quantity,
                    CustomerName = oi.Order.Customer.Name
                }).ToList();

                dataGridViewOrderItems.DataSource = orderItems;
            }
        }
    }
}
