using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using MarketManager.Data;

namespace MarketManager.Forms
{
    public partial class UpdateProductForm : Form
    {
        private DataContext _context;
        public UpdateProductForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (Guid.TryParse(IdTextBox.Text, out Guid userId))
            {
                var product = _context.Products.FirstOrDefault(u => u.Id == userId);
                try
                {
                    product.Name = NameTextBox.Text;
                    product.Category = CategoryTextBox.Text;
                    product.Price = Convert.ToInt32(PriceTextBox.Text);
                    _context.SaveChanges();
                    MessageBox.Show($"Product {product.Name} Updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error:{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Введите корректный GUID.");
            }
        }
    }
}
