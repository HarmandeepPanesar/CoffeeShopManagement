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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadProducts();

            btnAddOrder.Click += BtnAddOrder_Click;
            btnLoadOrders.Click += BtnLoadOrders_Click;
        }

        private void LoadCustomers()
        {
            using (var context = new CoffeeShopContext())
            {
                var customers = context.Customers.ToList();
                comboBoxCustomers.DataSource = customers;
                comboBoxCustomers.DisplayMember = "FullName"; // Assume you have a FullName property  
                comboBoxCustomers.ValueMember = "CustomerId";
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

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            int customerId = (int)comboBoxCustomers.SelectedValue;
            int productId = (int)comboBoxProducts.SelectedValue;
            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                using (var context = new CoffeeShopContext())
                {
                    var order = new Orders
                    {
                        CustomerID = customerId,
                        OrderDate = DateTime.Now,
                        TotalAmount = 0 // Will calculate later  
                    };

                    context.Orders.Add(order);
                    context.SaveChanges();

                    // Now add the order item  
                    var product = context.Products.Find(productId);
                    var orderItem = new OrderItems
                    {
                        OrderID = order.OrderID,
                        ProductID = productId,
                        Quantity = quantity,
                        TotalAmount = product.Price // Assuming price is stored in product  
                    };

                    context.OrderItems.Add(orderItem);
                    context.SaveChanges();

                    // Update total amount  
                    order.TotalAmount += orderItem.TotalAmount * quantity;
                    context.SaveChanges();

                    MessageBox.Show("Order added successfully!");
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
        }

        private void BtnLoadOrders_Click(object sender, EventArgs e)
        {
            using (var context = new CoffeeShopContext())
            {
                var orders = context.Orders
                    .Select(o => new
                    {
                        o.OrderID,
                        CustomerName = o.Customer.FirstName + " " + o.Customer.LastName,
                        o.OrderDate,
                        o.TotalAmount
                    }).ToList();

                dataGridViewOrders.DataSource = orders;
            }
        }

        private void ClearFields()
        {
            comboBoxCustomers.SelectedIndex = -1;
            comboBoxProducts.SelectedIndex = -1;
            txtQuantity.Clear();
        }
    }
}
