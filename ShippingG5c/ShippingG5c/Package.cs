using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingG5c
{
    abstract class Package: IPayable
    {
        public int ID;
        public string SenderName;
        public string SenderAddress;
        public string SenderCity;
        public string SenderState;
        public string SenderZipCode;
        public string RecipientName;
        public string RecipientAddress;
        public string RecipientCity;
        public string RecipientState; // You missed this one LOL
        public string RecipientZipCode;
        public decimal Weight;
        public decimal CostPerOunce= 0.5m;
        public decimal Cost;
        public string ShippingMethod;
        public string ShippingCompany;

        public Package() { }

        public Package(int iD, string senderName, string senderAddress, string senderCity, string senderState, string senderZipCode, string recipientName, string recipientAddress, string recipientCity, string recipientState, string recipientZipCode, decimal weight, decimal costPerOunce, decimal cost, string shippingMethod, string shippingCompany)
        {
            ID = iD;
            SenderName = senderName;
            SenderAddress = senderAddress;
            SenderCity = senderCity;
            SenderState = senderState;
            SenderZipCode = senderZipCode;
            RecipientName = recipientName;
            RecipientAddress = recipientAddress;
            RecipientCity = recipientCity;
            RecipientState = recipientState;
            RecipientZipCode = recipientZipCode;
            Weight = weight;
            CostPerOunce = costPerOunce;
            Cost = cost;
            ShippingMethod = shippingMethod;
            ShippingCompany = shippingCompany;
        }

      

        decimal IPayable.CalculateCost()
        {
           return (Cost += Weight * CostPerOunce);
        }
        
        public override string ToString()
        {
            return SenderName;
        }
    }
   
   
    
}
