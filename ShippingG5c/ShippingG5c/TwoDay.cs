using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingG5c
{
    class TwoDay:Package
    {
        public TwoDay() { }

        public TwoDay(int iD, string senderName, string senderAddress, string senderCity, string senderState, string senderZipCode, string recipientName, string recipientAddress, string recipientCity, string recipientState, string recipientZipCode, decimal weight, decimal costPerOunce, decimal cost, string shippingMethod, string shippingCompany) : base(iD, senderName, senderAddress, senderCity, senderState, senderZipCode, recipientName, recipientAddress, recipientCity, recipientState, recipientZipCode, weight, costPerOunce, cost, shippingMethod, shippingCompany)
        {
        }
        public TwoDay(decimal weight, decimal CostPerOunce)
        {
            this.Weight = weight;
            this.CostPerOunce = CostPerOunce;
        }
        public decimal CalculateCost()
        {
            return (Weight * CostPerOunce) + (50);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
