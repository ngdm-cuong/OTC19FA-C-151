using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    class Icons : PictureBox


    {
        private int iconValue;
        private static Random randNum = new Random();

        public int IconValue { get => iconValue; set => iconValue = value; }
        public static Random RandNum { get => randNum; set => randNum = value; }

        public static int Roll()
        {
            int iconValue = randNum.Next(0, 9);
            return iconValue;
           
        }

    }
}
