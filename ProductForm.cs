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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
            btnLoad.Click += BtnLoad_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (decimal.TryParse(txtPrice.Text, out decimal price) &&
                int.TryParse(txtStock.Text, out int stock))
            {
                string category = txtCategory.Text;

                using (var context = new CoffeeShopContext())
                {
                    var product = new Product
                    {
                        Name = name,
                        Price = price,
                        Category = category,
                        Stock = stock
                    };

                    context.Products.Add(product);
                    context.SaveChanges();
                }

                MessageBox.Show("Product added successfully!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please enter valid price and stock.");
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (var context = new CoffeeShopContext())
            {
                var products = context.Products.ToList();
                dataGridViewProducts.DataSource = products;
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtCategory.Clear();
            txtStock.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
