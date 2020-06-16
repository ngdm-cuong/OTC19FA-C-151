using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingG5c
{
    public partial class PrintLabel : Form
    {
        public PrintLabel()
        {
            InitializeComponent();
        }

       public PrintLabel(string ShipCompany, string TypeShipping,decimal weight,string shipInfo,string RecevierInfo)
        {
            InitializeComponent();
            label1.Text = ShipCompany;
            label2.Text = TypeShipping;
            label4.Text = DateTime.Now.ToShortDateString();
            label5.Text = weight.ToString();
            label3.Text = shipInfo;
            label6.Text = RecevierInfo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Bitmap printLabel;
        private void button1_Click(object sender, EventArgs e)
        { 
            printLabel = new Bitmap(labelPanel.Width, labelPanel.Height);
            labelPanel.DrawToBitmap(printLabel, new Rectangle(0, 0, labelPanel.Width, labelPanel.Height));
            printPreviewDialog1.ShowDialog();
        }


      

     

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(printLabel, 10, 10);
        }
    }
}
