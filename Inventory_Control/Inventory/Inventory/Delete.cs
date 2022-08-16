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
    public partial class Delete : Form
    {
        Product product;
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            product = new Product();
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = product.DisplayAll();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int text = int.Parse(txtdelete.Text);
            product.Remove(text);
            product.Save();
            dataGridView1.DataSource = product.DisplayAll();
        }
    }
}
