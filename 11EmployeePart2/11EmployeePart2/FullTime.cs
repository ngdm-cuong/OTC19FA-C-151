using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _11EmployeePart2
{
    class FullTime : Employee
    {
        #region Private fields
        private decimal salary;
        private int numOfVacationDays;
        private string hasInsurance;
        private string taxExempt;
        private int numOfSickDays;

        public FullTime(decimal salary, int numOfVacationDays, string hasInsurance, string taxExempt, int numOfSickDays)
        {
            this.salary = salary;
            this.numOfVacationDays = numOfVacationDays;
            this.hasInsurance = hasInsurance;
            this.taxExempt = taxExempt;
            this.numOfSickDays = numOfSickDays;
        }
        #endregion
        #region Public properties
        public decimal Salary { get => salary; set => salary = value; }
        public int NumOfVacationDays { get => numOfVacationDays; set => numOfVacationDays = value; }
        public string HasInsurance { get => hasInsurance; set => hasInsurance = value; }
        public string TaxExempt { get => taxExempt; set => taxExempt = value; }
        public int NumOfSickDays { get => numOfSickDays; set => numOfSickDays = value; }
        #endregion

        public FullTime() { } 
        public override decimal CalcTotalEarnings()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            string output;
            output = $"Employee ID: {ID} \n" +
                    $"Name: {FirstNanme}" +
                    $"{LastName} " +
                    $"Date Hired: {DateHired} " +
                    $"SSN: {SSN} " +
                    $"Email: {Email} \t Phone: {Phone} " +
                    $"Tax: {TaxRate} " +
                    $"Salary :{salary} " +
                    $"Number of Vacation days: {numOfSickDays} " +
                    $"Has Insurance : {hasInsurance} " +
                    $"Tax Exempt: {taxExempt} " +
                    $"Number of sick days: {numOfSickDays} ";
            Console.WriteLine(output);
            return output;
        }
        public override decimal CalcTaxes()
        {
            return base.CalcTaxes();
        }
        
    }
}
