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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        Product product;
        private void btnadd_Click(object sender, EventArgs e)
        {
            product = new Product();
            string path = "Data Source= DESKTOP-02T8VQI\\SQLEXPRESS;Initial Catalog= Inventory;Integrated security=true;";
            SqlConnection conn;
            SqlCommand cmd;
            DataValidation valid;
            //Exception

            try
            {
                var str = "";

                foreach (var s in checkedListBox1.CheckedItems)
                {
                    str += " " + s.ToString();
                }
                product.Object_Name = txtobject.Text;
                product.Inventory_Number = int.Parse(txtnumber.Text);
                product.dateTime = dateTimePicker1.Value;
                product.Count = int.Parse(txtcount.Text);
                product.Price = double.Parse(txtprice.Text);
                product.Original = radioButton1.Checked;
                product.Refurbished= radioButton2.Checked;
                product.Checked = str;
                conn = new SqlConnection(path);
                conn.Open();
                cmd = new SqlCommand("INSERT INTO AddProduct VALUES('" + product.Object_Name+ "','" + product.Inventory_Number+ "','" +product.Count + "','" + product.Price + "','" + product.dateTime + "','" + product.Original + "','" + product.Refurbished + "','" + product.Is_Available + "','" + str+ "')", conn);
                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
            valid = new DataValidation(product);
            if (valid.TotalValidation())
            {
                product.Save();
                MessageBox.Show(" **** ADDED SUCCESSFULLY***********");
            }
            else
                MessageBox.Show(" Data Validation Error ");

        }
    }
}
