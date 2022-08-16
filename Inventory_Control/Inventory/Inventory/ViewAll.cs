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
    public partial class ViewAll : Form
    {
        Product product;
        public ViewAll()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {
            product = new Product();
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = product.DisplayAll();
        }
    }
}
