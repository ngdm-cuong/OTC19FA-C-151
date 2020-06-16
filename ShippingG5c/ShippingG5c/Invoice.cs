using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ShippingG5c
{
     class Invoice
    {
        public int ID;
        public  ArrayList Packages = new ArrayList(); // Cannot be static 
        //static public Package[] Packages = new Package[50];
        static public decimal TaxRate = 0.3M;
        public decimal subTotal =0;
        public decimal TotalCost;
        public decimal TaxTotal = 0;
        public Invoice() { }

        public Invoice(int iD)
        {
            ID = iD;
        }

        /// <summary>
        /// Author: Cuong Nguyen
        /// Purpose: To calculate the sum of all the tax amount from all the package in 1 invoice
        /// </summary>
        /// <returns></returns>
        public void CalculateTax()
        {
             subTotal = 0;
          
            foreach (Package item in Packages)
            {
                if(item.ShippingMethod == "Over Night")
                {
                    OverNight newItem = new OverNight(item.Weight,item.CostPerOunce);
                    subTotal += newItem.CalculateCost();
                }
                else
                {
                    TwoDay newItem = new TwoDay(item.Weight, item.CostPerOunce);
                    subTotal += newItem.CalculateCost();
                }
            }
            TaxTotal += subTotal * TaxRate;
        }
        /// <summary>
        /// Author: CuongNguyen
        /// Purpose: To calculate the final total for the invoice
        /// </summary>
        /// <returns></returns>
        public void CalculateTotal()
        {
            
            

            TotalCost += TaxTotal + subTotal;
            // Use this to double check
            //TotalCost = CalculateTax() + subTotal;
            
        }
        public override string ToString()
        {

            return "SubTotal: $"+ subTotal.ToString()+"\nTax: $"+TaxTotal.ToString()+"\nTotal: $"+TotalCost.ToString();
        }
    }
}
