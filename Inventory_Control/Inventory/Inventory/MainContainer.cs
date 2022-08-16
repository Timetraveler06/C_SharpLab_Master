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
    public partial class MainContainer : Form
    {
        public MainContainer()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = ActiveMdiChild;
            if (Form != null)
            {
                Form.Close();
            }
            AddProduct form = new AddProduct();
            form.MdiParent = this;
            form.Show();
        }

        private void goBackToLognToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
    }
}
