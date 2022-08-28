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
    public partial class ProductUserControl : UserControl
    {
       
        private string myVar;
        
       
        public string MyProperty
        {
            get { return myVar; }
            set { myVar = value; label8.Text = value; }
                     
        }
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; label10.Text = value; }
        }
        private  string dateTime { get; set; }


        public  string Date
        {
            get { return dateTime; }
            set { dateTime = value;label9.Text = value; }
        }
        private string oobject { get; set; }
         public string Object
         {
        get { return oobject; }
        set { oobject = value; label11.Text = value; }
         }

    private string count;

        public string Count
        {
            get { return count; }
            set { count = value; label13.Text = value; }
        }
        private string is_available;

        public string Is_Available
        {
            get { return is_available; }
            set { is_available = value;label12.Text = value; }
        }


        private string original;

        public string Original
        {
            get { return original; }
            set { original = value; label2.Text = value; ; }
        }


        private string refurbished;

        public string Refurbished
        {
            get { return refurbished; }
            set { refurbished = value; label4.Text = value; }
        }

        private string check;

      

        public string Checked
        {
            get { return check; }
            set { check = value;label14.Text = value; }
        }

        public ProductUserControl()
        {
            InitializeComponent();
        }
        public ProductUserControl(int number,string Name,DateTime time, double price,int count, string Checked, bool availability,bool original,bool refur)
        {
            InitializeComponent();
            this.MyProperty = number.ToString();
            this.Object = Name;
            this.Date = time.ToString();
            this.Price = price.ToString();
            this.Count = count.ToString();
            this.Checked = Checked;
            this.Is_Available = availability.ToString();
            this.Original = original.ToString();
            this.Refurbished = refur.ToString();

           

        }

        

        private void ProductUserControl_Load(object sender, EventArgs e)
        {

        }

        public void Card(object sender, EventArgs e)
        {
            MessageBox.Show(" Card clicked");
        }

       
    }
}
