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

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Search form = new Search();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            ViewAll form = new ViewAll();
            form.MdiParent = this;
            form.Show();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Delete form = new Delete();
            form.MdiParent = this;
            form.Show();

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
