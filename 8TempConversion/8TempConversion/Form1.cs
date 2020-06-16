using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
///  Author: Cuong Nguyen
///  Date: 4/12/2019
///  Purpose: Create a from that converts Farenheit degrees to Celsious
/// </summary>
namespace _8TempConversion
{
    public partial class Form1 : Form
    {
        decimal farenheit;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: Check if user enter properly to the box and then convert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal celsius;
            if (!decimal.TryParse(txtTemp.Text, out farenheit))
            {
                MessageBox.Show("Please re-enter the Temperature!");
                lblF.Text = "Can not convert!";
            }
            else
            {               
                celsius = (farenheit - 32) * 5 / 9;
                lblF.Text = $"{farenheit} degrees Farenheit is\n{celsius:f} degrees Celsius."; 
            }



        }
    }
}
