using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project5
{
    class Phone
    {
        private string prodCode;
        private string name;
        private int qty;
        private decimal cost;
        private decimal price;


        public string ProdCode {
            get
            {
                return prodCode;
            }
            set
            {
                prodCode = value;
            }
        }
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Qty {
            get
            {
                return qty;
            }
            set
            {
                qty = value;
            }
        }
        public decimal Cost {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public Phone(string prodCode, string name, int qty, decimal cost, decimal price)
        {
            this.prodCode = prodCode;
            this.name = name;
            this.qty = qty;
            this.cost = cost;
            this.price = price;
        }
        public Phone() {
            this.prodCode = "Default code";
            this.name = "Default name";
            this.qty = 0;
            this.cost = 0;
            this.price = 0;

        }
        public decimal CaclProfit (){

            return (qty*price);
        }
        public void PrintValues()
        {
            WriteLine($"Phone values: {qty * cost:c}");
        }
        public override string ToString () {
            string message = "";
            message += $"ProdCode    : {prodCode}\n";
            message += $"Name        : {name}\n";
            message += $"Qty         : {qty}\n";
            message += $"Cost        : {cost:c}\n";
            message += $"Price       : {price:C}\n";

            return message;
        }
    }   // End of Class
}
