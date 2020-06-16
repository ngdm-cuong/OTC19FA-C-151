using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public abstract class BasePlay
    {
        private double credit;
        private double jackPot;
        private double winAmount;
        private double loseAmount;
        // private static bool payed;

        public double Credit { get => credit; set => credit = value; }
        public double JackPot { get => jackPot; set => jackPot = value; }
        public double WinAmount { get => winAmount; set => winAmount = value; }
        public double LoseAmount { get => loseAmount; set => loseAmount = value; }

        public virtual int Cheating()
        {
            // I am plaing on somehow changing the timeinterval so it would be easier to got 2 or 3 of a kinds
            return 0;
        }
        public abstract double CalCredit(double credit, double creditChanging);
    }
}
