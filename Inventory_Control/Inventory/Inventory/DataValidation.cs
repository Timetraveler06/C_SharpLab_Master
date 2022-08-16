using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inventory
{
    internal class DataValidation
    {
        Product prod;

        public DataValidation()
        {

        }

        public DataValidation(Product product)
        {
            prod = product;
        }

        public bool ValidateName()
        {
            Regex nameReg = new Regex("^[A-Za-z\\s]{2,25}$");
            if (nameReg.IsMatch(prod.Object_Name))
            {
                return true;
            }
            else return false;


        }
        public bool ValidatePrice()
        {
            Regex nameReg = new Regex("^[0-9]{1,6}[.]{0,1}[0-9]{0,2}$");
            if (nameReg.IsMatch(prod.Price.ToString()))
            {
                return true;
            }
            else return false;


        }
        public bool ValidateCount()
        {
            Regex nameReg = new Regex("^[1-9]{1,9}$");
            if (nameReg.IsMatch(prod.Count.ToString()))
            {
                return true;
            }
            else return false;


        }
        public bool TotalValidation()
        {
            if (ValidateName())
            {

                if (ValidatePrice())
                {
                    if (ValidateCount())
                    {


                        return true;
                    }
                }
            }
            return false;
        }

    }

}

