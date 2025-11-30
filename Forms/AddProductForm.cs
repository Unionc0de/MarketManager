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
using MarketManager.Models;

namespace MarketManager.Forms
{
    public partial class AddProductForm : Form
    {
        private DataContext _context;
        public AddProductForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product(NameTextBox.Text,CategoryTextBox.Text,Convert.ToInt32(PriceTextBox.Text));
                _context.Products.Add(product);
                _context.SaveChanges();

                MessageBox.Show("Product created!");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
