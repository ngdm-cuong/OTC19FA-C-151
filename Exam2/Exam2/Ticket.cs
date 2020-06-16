using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exam2
{
    class Ticket
    {
        #region Data fields
        private string ticketNo;
        private DateTime timeIn;
        private DateTime timeOut;
        public static int count;
        public static BitArray Garage = new BitArray(25);
        public static Ticket[] TicketArray = new Ticket[25];
        #endregion
        #region Public properties
        public string TicketNo { get => ticketNo; set => ticketNo = value; }
        public DateTime TimeIn { get => timeIn; set => timeIn = value; }
        public DateTime TimeOut { get => timeOut; set => timeOut = value; }
        #endregion
        #region Constructors
        public Ticket(string ticketNo, DateTime timeIn, DateTime timeOut)
        {
            this.ticketNo = ticketNo;
            this.timeIn = timeIn;
            this.timeOut = timeOut;
        }
        public Ticket() { }

        public Ticket(string ticketNo)
        {
            this.ticketNo = ticketNo;
        }

        #endregion
        #region Methods
        public static decimal CalculateCharege(DateTime timeIn, DateTime timeOut)
        {
            decimal charge = 0;
            decimal rate = 0.5M;
            TimeSpan difference = timeOut - timeIn;
           
            decimal duration = Math.Ceiling((decimal) difference.TotalMinutes / 60); // Passing double as decimal

            Console.WriteLine(duration);

            if (duration <= 3)
            {
                charge = 2;

            }
            else if (duration > 3 && duration < 24)
                charge = 2 + (duration - 3) * rate;
            else
                charge = 10;
            return charge;
        }
        public override string ToString()
        {
            string message;
            message = $"Ticket #{ticketNo}. Time In: {timeIn}";
            return message;
        }
        public static void Count()
        {
            count++;
        }

        #endregion
    }
}
