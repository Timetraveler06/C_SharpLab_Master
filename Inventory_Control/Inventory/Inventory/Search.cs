using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Search : Form
    {
        Product product;
        public Search()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = product.findOne(name);

        }

        private void Search_Load(object sender, EventArgs e)
        {
            product = new Product();
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = product.DisplayAll();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
