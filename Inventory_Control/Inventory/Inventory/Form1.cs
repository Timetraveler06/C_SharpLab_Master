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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
            

        }

        private void btnlogin_Click(object sender, EventArgs e)

        {
            string path = "Data Source= DESKTOP-02T8VQI\\SQLEXPRESS;Initial Catalog= Inventory;Integrated security=true;";
            SqlConnection conn;
            try
            {
                Login form = new Login();
                DataValidation dv;
                MainContainer mainContainer = new MainContainer();
                string username = txtusername.Text;
                string password = txtpassword.Text;
                SqlCommand cmd;

                dv = new DataValidation(username, password);
                
                if (dv.ValidateLogin())
                {
                    conn = new SqlConnection(path);
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO LoginPage VALUES('" + username + "','" + password + "')", conn);
                  
                    cmd.ExecuteNonQuery();
                    mainContainer.Show();
                    form.Hide();

                }
               
               


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
           // dv= new DataValidation(username,password);
            /*
            if (dv.ValidateLogin())
            {
                mainContainer.Show();
                form.Hide();

            }
            else
                MessageBox.Show(" Incorrect UserName or Password");
            */

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
