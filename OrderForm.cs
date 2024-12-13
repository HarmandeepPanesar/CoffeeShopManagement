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
        public OrderForm(Customer customer)
        {
            InitializeComponent();
            LoadLastAddedCustomer(customer);
            LoadProducts();
            btnNext.Click += BtnNext_Click; // Attach event handler to the Next button  
            btnAddOrder.Click += BtnAddOrder_Click;
            btnLoadOrders.Click += BtnLoadOrders_Click;
        }
        public OrderForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadProducts();
            btnNext.Click += BtnNext_Click; // Attach event handler to the Next button  
            btnAddOrder.Click += BtnAddOrder_Click;
            btnLoadOrders.Click += BtnLoadOrders_Click;
        }

        private void BtnNext_Click(object sender, EventArgs e) // Event handler for Next button click  
        {
            // Validate input (you can expand this validation as needed)
            if (string.IsNullOrWhiteSpace(comboBoxProducts.Text))
            {
                MessageBox.Show("Please enter an order type."); // Show message if input is invalid  
                return; // Exit the method  
            }

            // Create a new Order object with user input  
            var orderDetails = new Orders
            {
                // Here you can add other properties as needed, for example:
                // OrderType = txtOrderType.Text;
                OrderItems = new List<OrderItems>() // Initialize the OrderItems list  
            };

            // Create the Customer Details Form and pass the order details  
            //var customerForm = new CustomerForm(orderDetails);
            //customerForm.Show(); // Show the Customer Details Form  
            //this.Hide(); // Hide the current Order Form  
        }
        private void LoadCustomers()
        {
            using (var context = new CoffeeShopContext())
            {
                var customers = context.Customers.ToList();
                comboBoxCustomers.DataSource = customers;
                comboBoxCustomers.DisplayMember = "Name"; // Assume you have a FullName property  
                comboBoxCustomers.ValueMember = "CustomerID";
            }
        }
        private void LoadLastAddedCustomer(Customer customer)
        {
            using (var context = new CoffeeShopContext())
            {
                var customers = context.Customers.Where(m => m.Email == customer.Email).ToList();
                comboBoxCustomers.DataSource = customers;
                comboBoxCustomers.DisplayMember = "Name"; // Assume you have a FullName property  
                comboBoxCustomers.ValueMember = "CustomerID";
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
                    // Update total amount  


                    // Now add the order item  
                    var product = context.Products.Find(productId);
                    var orderItem = new OrderItems
                    {
                        OrderID = order.OrderID,
                        ProductID = productId,
                        Quantity = quantity,
                    };

                    context.OrderItems.Add(orderItem);
                    context.SaveChanges();

                    order.TotalAmount += product.Price * quantity;
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
                        CustomerName = o.Customer.Name,
                        o.OrderDate,
                        o.TotalAmount,
                        OrderedItems = string.Join(", ", o.OrderItems.Select(oi => $"{oi.Product.Name} (Qty: {oi.Quantity})")) 

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

        private void button1_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();
            customerForm.Show(); // Show the Customer Details Form  
            this.Hide(); // Hide the current Order Form  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var customerForm = new OrderItemsForm();
            customerForm.Show(); // Show the Customer Details Form  
            //this.Hide(); // Hide the current Order Form  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var customerForm = new ProductForm();
            customerForm.Show(); // Show the Customer Details Form  
            //this.Hide(); // Hide the current Order Form  
        }
    }
}
