using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketManager.Data;
using Microsoft.EntityFrameworkCore;

namespace MarketManager.Forms
{
    public partial class DeleteProductForm : Form
    {
        private DataContext _context;
        
        public DeleteProductForm()
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Guid.TryParse(IdTextBox.Text, out Guid userId))
            {
                var product = _context.Products.FirstOrDefault(u => u.Id == userId);
                try
                {
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                    MessageBox.Show($"Product {product.Name} deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error:{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Enter correct ID");
            }
        }
    }
}
