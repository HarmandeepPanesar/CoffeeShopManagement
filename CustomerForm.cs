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
        public CustomerForm()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
            btnLoad.Click += BtnLoad_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            using (var context = new CoffeeShopContext())
            {
                var customer = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Phone = phone
                };

                context.Customers.Add(customer);
                context.SaveChanges();
            }

            MessageBox.Show("Customer added successfully!");
            ClearFields();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
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
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }
    }
}
