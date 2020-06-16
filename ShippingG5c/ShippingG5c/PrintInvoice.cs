using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class PrintInvoice : Form
    {
  
        public PrintInvoice(string packageInfo, string cost)
        {
            InitializeComponent();
            label1.Text = packageInfo;
            label2.Text = cost;
            label3.Text = DateTime.Now.ToShortDateString();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Bitmap printLabel;
        private void button1_Click(object sender, EventArgs e)
        {
            printLabel = new Bitmap(labelPanel.Width, labelPanel.Height);
            labelPanel.DrawToBitmap(printLabel, new Rectangle(0, 0, labelPanel.Width, labelPanel.Height));
            printPreviewDialog1.ShowDialog();
        }
      

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(printLabel, 10, 10);
        }
    }
}
