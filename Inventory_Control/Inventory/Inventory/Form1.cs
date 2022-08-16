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
            Login form = new Login();
            DataValidation dv;
            MainContainer mainContainer = new MainContainer();
            string username = txtusername.Text;
            string password = txtpassword.Text;
            dv= new DataValidation(username,password);
            if (dv.ValidateLogin())
            {
                mainContainer.Show();
                form.Hide();

            }
            else
                MessageBox.Show(" Incorrect UserName or Password");


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
