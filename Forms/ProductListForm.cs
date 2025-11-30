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
    public partial class ProductListForm : Form
    {
        private DataContext _context;
        public ProductListForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Products.ToList();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Products.ToList();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }

        private void SortByNameButton_Click(object sender, EventArgs e)
        {
            List<Product> sortedProducts = _context.Products.OrderBy(p => p.Name).ToList();
            dataGridView1.DataSource = sortedProducts;
        }

        private void SortByCategoryButton_Click(object sender, EventArgs e)
        {
            List<Product> sortedProducts = _context.Products.OrderBy(p => p.Category).ToList();
            dataGridView1.DataSource = sortedProducts;
        }

        private void SortByPriceButton_Click(object sender, EventArgs e)
        {
            List<Product> sortedProducts = _context.Products.OrderBy(p => p.Price).ToList();
            dataGridView1.DataSource = sortedProducts;
        }
    }
}
