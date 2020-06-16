using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Play : BasePlay 
    {
       // public static bool Payed { get => Payed; set => Payed = value; }

        public override double CalCredit(double credit, double creditChanging)
        {  
            return(credit + creditChanging);
        }
    }

}
