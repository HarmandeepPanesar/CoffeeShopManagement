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
            //LoadOrders();
            LoadProducts();

            btnAddOrderItem.Click += BtnAddOrderItem_Click;
            btnLoadOrderItems.Click += BtnLoadOrderItems_Click;
        }

        private void LoadOrders()
        {
            using (var context = new CoffeeShopContext())
            {
                var orders = context.Orders.ToList();
                comboBoxOrders.DataSource = orders;
                comboBoxOrders.DisplayMember = "OrderId"; // Displaying order ID for simplicity  
                comboBoxOrders.ValueMember = "OrderId";
            }
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

        private void BtnAddOrderItem_Click(object sender, EventArgs e)
        {
            int orderId = (int)comboBoxOrders.SelectedValue;
            int productId = (int)comboBoxProducts.SelectedValue;

            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                using (var context = new CoffeeShopContext())
                {
                    var product = context.Products.Find(productId);
                    var orderItem = new OrderItems
                    {
                        OrderID = orderId,
                        ProductID = productId,
                        Quantity = quantity,
                        TotalAmount = product.Price // Assume price is stored in product  
                    };

                    context.OrderItems.Add(orderItem);
                    context.SaveChanges();

                    MessageBox.Show("Order item added successfully!");
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }

        private void BtnLoadOrderItems_Click(object sender, EventArgs e)
        {
            int orderId = (int)comboBoxOrders.SelectedValue;

            using (var context = new CoffeeShopContext())
            {
                var orderItems = context.OrderItems
                    .Where(oi => oi.OrderID == orderId)
                    .Select(oi => new
                    {
                        oi.OrderItemID,
                        ProductName = oi.Product.Name,
                        oi.Quantity,
                        oi.TotalAmount
                    }).ToList();

                dataGridViewOrderItems.DataSource = orderItems;
            }
        }

        private void ClearFields()
        {
            comboBoxOrders.SelectedIndex = -1;
            comboBoxProducts.SelectedIndex = -1;
            txtQuantity.Clear();
        }
    }
}
