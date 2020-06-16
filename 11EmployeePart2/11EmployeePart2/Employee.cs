using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11EmployeePart2
{
    public abstract class Employee
    {
        #region Private data field
        private string firstNanme;
        private string lastName;
        private DateTime dateHired;
        private string sSN;
        private string email;
        private string phone;
        private decimal taxRate;
        private int iD;
        #endregion
        #region Public properties 
        public string FirstNanme { get => firstNanme; set => firstNanme = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateHired { get => dateHired; set => dateHired = value; }
        public string SSN { get => sSN; set => sSN = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public decimal TaxRate { get => taxRate; set => taxRate = value; }
        public int ID { get => iD; set => iD = value; }
        #endregion
        #region Methods
        public override string ToString()
        {
            string returnString = "";
            returnString += $"First Name: \t{firstNanme}";
            returnString += $"Last Name: \t{lastName}";
            returnString += $"Date hired: \t{dateHired}";
            returnString += $"SSN: \t{SSN}";
            returnString += $"Email: \t{ email}";
            returnString += $"Phone: \t{phone}";
            returnString += $"Tax rate: \t{taxRate}";
            returnString += $"ID: \t{iD}";

            return returnString;
        }
        public virtual decimal CalcTaxes()
        {
            decimal taxes = 0;
            return taxes;
        }
        public abstract decimal CalcTotalEarnings();
        #endregion
    }// End of class
}// End of namespace
