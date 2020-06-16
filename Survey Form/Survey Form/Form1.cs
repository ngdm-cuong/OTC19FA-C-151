using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_Form
{
    /// <summary>
    /// AUthor: Cuong Nguyen
    /// Date: 4/12/2019
    /// Purpose: Creating a survey form
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Variable Declaring
        /// </summary>
        public string name   = "";
        public string number = "";
        string message      = "";
        string bday         = "";
        decimal cars;
        bool booName    = false;
        bool booNumber  = false;
        bool booAge     = false;
        bool booCheck   = false;
        bool booBday    = false;
        bool booCars    = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            name = txtName.Text;
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

            number = txtNumber.Text;
        }

        private void Submit_Click(object sender, EventArgs e)
        { 

            // With Every section completed, there will be a boolean value to check it 
            message = "";
            message += $"Name:{name}\n";
            message += $"Phone Number:{number}\n";
            #region TEXT BOX 
            if (name == "")
                booName = false;
            else
                booName = true;

            if (number == "")
                booNumber = false;
            else
                booNumber = true;
            #endregion
            #region Age
            if (radUnder18.Checked)
            {
                message += "I am over 18.\n";
                booAge = true;
            }

            else
            {
                message += "I am under 18.\n";
                booAge = true;
            }
            #endregion
            #region Birthday
            message += $"I was born on {bday}.\n";

            if (bday == "")
                booBday = false;
            else
                booBday = true;
            #endregion
            #region ITEM CHECKING

            message += ("I usually bring: ");

            if (chkCharger.Checked)
            {
                message += "Charger ";
                booCheck = true;
            }
                
            if (chkJacket.Checked)
            {
                message += "Jacket ";
                booCheck = true;
            }
               

            if (chkKeys.Checked)
            {
                message += "Keys ";
                booCheck = true;
            }
                
            if (chkPhone.Checked)
            {
                message += "Phone ";
               booCheck = true;
            }
                
            if (chkWallet.Checked)
            {
                message += "Wallet ";
                booCheck = true;
            }
            #endregion
            #region CAR
            if (numericUpDown1.Value == 1)

                message += $"\nI own {cars.ToString()} car";
            else
                message += $"\nI own {cars.ToString()} cars";
            #endregion
            message += "\n\nThank you for takting time to complete the survey!";

            #region Checking if every thing is filled
            if (booName == false || booNumber == false || booAge == false || booCheck == false || booBday == false)
                MessageBox.Show("Please complete all sections!");
            else
                MessageBox.Show(message);
            #endregion
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // RESET EVERYTHING
            name                = "";
            number              = "";
            bday                = "";
            message             = "";
            cars                = 0;
            txtName.Text        = "";
            txtNumber.Text      = "";
            lblBday.Text        = "Birthday: ";
            numericUpDown1.Value = 0;

            chkCharger.Checked = false;
            chkJacket.Checked = false;
            chkKeys.Checked = false;
            chkPhone.Checked = false;
            chkWallet.Checked = false;

            radOver18.Checked = false;
            radUnder18.Checked = false;

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //CONVERT calendar value to string
            bday = monthCalendar1.SelectionRange.Start.ToShortDateString();
            lblBday.Text = "Birthday: "+ monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // get value form numeric up down
            cars = numericUpDown1.Value;
        }

        private void lblBday_Click(object sender, EventArgs e)
        {

        }
    }
}
