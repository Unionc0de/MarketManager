using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketManager.Forms;

namespace MarketManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            ProductListForm frm = new ProductListForm();
            frm.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddProductForm frm = new AddProductForm();
            frm.Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateProductForm frm = new UpdateProductForm();
            frm.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteProductForm frm = new DeleteProductForm();
            frm.Show();
            this.Hide();
        }
    }
}
