using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
            
           
            try
            {
                
                product = new Product();
                
                
                flowLayoutPanel1.Controls.Clear();
                foreach (var Item in product.Displayy())
                {
                    ProductUserControl pc = new ProductUserControl(Item.Inventory_Number, Item.Object_Name, Item.dateTime, Item.Price, Item.Count, Item.Checked, Item.Is_Available, Item.Original, Item.Refurbished);
                    pc.Click += pc.Card;
                   
                    flowLayoutPanel1.Controls.Add(pc);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
