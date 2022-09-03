using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Inventory
{
    public class Product
    {
        public string Object_Name { get; set; }
        public int Inventory_Number { get; set; }
        public int Count { get; set; }

        public double Price { get; set; }
        public DateTime dateTime { get; set; }
        public bool Original { get; set; }
        
        public bool Refurbished { get; set; }
        public bool Is_Available { get; set; }
        public string Checked { get; set; }



        private static List<Product> list = new List<Product>();


        public Product SearchProductsByName(string ProductsName, List<Product> products)

        {

            Product pd = products.SingleOrDefault(p => p.Object_Name == ProductsName);


            return pd;
        }
       
        public List<Product> DisplayAll()
        {

            return list;
        }
        public List<Product> findOne(string Object_Name)
        {
            return DisplayAll().FindAll(p => p.Object_Name == Object_Name);

        }
        public void Save()
        {
            list.Add(this);
        }
        public bool Remove(int number)
        {
            if (list.Count > 0)
            {
                number= this.Inventory_Number;
                list.RemoveAt(number);
                return true;
            }
            return false;

        }
        public List<Product>  Displayy()
        {

        string path = "Data Source= DESKTOP-02T8VQI\\SQLEXPRESS;Initial Catalog= Inventory;Integrated security=true;";
        string query = "SELECT * FROM AddProduct";
        SqlConnection conn;
        conn = new SqlConnection(path);
        conn.Open();
        SqlCommand cmd = new SqlCommand(query,conn);
        var result = cmd.ExecuteReader();
        List<Product> temp = new List<Product>();
        while (result.Read())
            {
                Product p = new Product();
                p.Object_Name = result["Obj"].ToString();
                    
                p.Inventory_Number = Convert.ToInt32(result["Inventory_Number"]);
                p.Count = Convert.ToInt32(result["Coun"]);
                p.Price = Convert.ToDouble(result["Price"]);
                p.dateTime =Convert.ToDateTime(result["datetime1"]);
                p.Original = Convert.ToBoolean(result["Original"]);
                p.Refurbished = Convert.ToBoolean(result["Refurbished"]);
                p.Is_Available = Convert.ToBoolean(result["Is_Available"]);
                p.Checked = result["Checked"].ToString();


                temp.Add(p);
                

            }
            return temp;
    }
       // private void card_click(object o ,)
    }
}
