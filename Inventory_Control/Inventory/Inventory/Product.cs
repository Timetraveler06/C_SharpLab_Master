using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
       // private void card_click(object o ,)
    }
}
