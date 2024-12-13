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
    public partial class CustomerForm : Form
    {
        public Customer LastAddedCistomer;
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomers();
            LastAddedCistomer = new Customer();
            btnAdd.Click += BtnAdd_Click;
            btnLoad.Click += BtnLoad_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter the customer details."); // Show message if input is invalid  
                return; // Exit the method  
            }
            else
            {
                string firstName = txtFirstName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;

                using (var context = new CoffeeShopContext())
                {
                    var customer = new Customer
                    {
                        Name = firstName,
                        Email = email,
                        Phone = phone
                    };

                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
                LastAddedCistomer = new Customer
                {
                    Name = firstName,
                    Email = email,
                    Phone = phone
                };
                MessageBox.Show("Customer added successfully!");
                ClearFields();
                LoadCustomers();
            }

        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (var context = new CoffeeShopContext())
            {
                var customers = context.Customers.ToList();
                dataGridViewCustomers.DataSource = customers;
            }
        }
        private void LoadCustomers()
        {
            using (var context = new CoffeeShopContext())
            {
                var customers = context.Customers.ToList();
                dataGridViewCustomers.DataSource = customers;
            }
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_button1_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm(LastAddedCistomer);
            orderForm.Show(); 
            this.Hide(); // Hide the current Order Form  
        }
    }
}
