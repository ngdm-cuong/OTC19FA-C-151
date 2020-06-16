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
/// Author:         Cuong Nguyen
/// Date:           4/19/2019
/// Purpose:        Order pizza app
/// </summary>
namespace PizzaDelivery
{

    public partial class Form1 : Form
    {
        public string strSoda, strWater;
        public string strSize;
        public string special;
        public string crust;
        public string strCrust;
        public string strTopping = "";
        public string receipt;

        public double cost = 0;
        public double costSize = 0;
        public double costSpecial = 0;
        public double costToping = 0;
        public decimal water;
        public int QtySoda, QtyWater,QtyTopping;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSize.SelectedIndex == 0)
            {
                costSize = 8;
                strSize = ("Size: Small \t\t\t\t $8.00\n");
            }
            else if (cbSize.SelectedIndex == 1)
            {
                costSize = 11.75;
                strSize = ("Size: Medium \t\t\t\t $11.75\n");
            }
            else
            {
                costSize = 12.95;
                strSize = ("Size: Large \t\t\t\t $12.95\n");
            }

        }

        private void cbCrust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCrust.SelectedIndex == 0)
            {
                crust = "Thin";
                strCrust = ($"Crust: {crust}\n");
            }

            else if (cbCrust.SelectedIndex == 1)
            {
                crust = "Thick";
                strCrust = ($"Crust: {crust}\n");
            }

            else if (cbCrust.SelectedIndex == 2)
            {
                crust = "Crispy";
                strCrust = ($"Crust: {crust}\n");
            }

            else if (cbCrust.SelectedIndex == 3)
            {
                crust = "Thin and Crispy";
                strCrust = ($"Crust: {crust}\n");
            }

            else
            {
                crust = "Thick and Crispy";
                strCrust = ($"Crust: {crust}\n");
            }

        }

        private void chkTopping_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                QtyTopping++;
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                QtyTopping--;
            }
            costToping = QtyTopping * 1.50;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            QtySoda = Convert.ToInt16(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            QtyWater = Convert.ToInt16(numericUpDown2.Value);

        }

        private void cbSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbSpecialty.SelectedIndex == 1)
            {
                double costWings;
                costWings = 5.00;
                special = ($"Special Item: Chicken Wings \t\t\t ${costWings:f2}");
                costSpecial = costWings;

            }
            else if (cbSpecialty.SelectedIndex == 2)
            {
                double costLegs;
                costLegs = 3.95;
                special = ($"Special Item: Chicken Legs \t\t\t ${costLegs:f2}");
                costSpecial = costLegs;

            }
            else if (cbSpecialty.SelectedIndex == 3)
            {
                double costFries;
                costFries = 3.00;
                special = ($"Special Item: French Frie \t\t\t ${costFries:f2}");
                costSpecial = costFries;
            }
            else if (cbSpecialty.SelectedIndex == 4)
            {
                double costPotsticker;
                costPotsticker = 3.80;
                special = ($"Special Item: Potsticker \t\t\t ${costPotsticker:f2}");
                costSpecial = costPotsticker;

            }
            else
            {
                special = "";
                costSpecial = 0;
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Size choosing and Topping choosing are mandatory
            if (cbSize.SelectedItem == null)
                MessageBox.Show("Please choose size!");
            else if (QtyTopping == 0)
                MessageBox.Show("Please choose at least 1 topping");
            else
            {
                ReceiptPringting();
                MessageBox.Show(receipt);
            }

        }


        /// <summary>
        /// Purpose: Calculating cost and printing receipt
        /// </summary>
        private void ReceiptPringting()
        {


            #region Size
            receipt += strSize;
            cost += costSize;
            #endregion

            #region Crust
            receipt += strCrust;
            #endregion

            #region Topping
            // Topping checking
            foreach (string item in chkTopping.CheckedItems)
            {
                if (item == "Mushroom" || item == "Green Pepper")
                    strTopping += ($"Topping: {item} \t\t\t $1.50\n"); // Make the receipt look more align
                else
                    strTopping += ($"Topping: {item} \t\t\t\t $1.50\n");

            }
            receipt += ($"{strTopping}");
            cost += costToping;
            #endregion

            #region Soda
            strSoda += ($"Soda \t\t\t\t\t $1.75 * {QtySoda}\n");
            if (QtySoda != 0) // Check if user choose drink, if they don't there won't be drink in the receipt
                receipt += ($"{strSoda}");
            cost += QtySoda * 1.75;
            #endregion

            #region Water
            strWater += ($"Water: \t\t\t\t\t $0.00 * {QtyWater}\n");
            if (QtyWater != 0) // Check if user choose drink, if they don't there won't be drink in the receipt
                receipt += ($"{strWater}");
            #endregion

            #region Special
            receipt += ($"{special}\n");
            cost += costSpecial;
            #endregion

            // Printing Total
            receipt += ($"Total: \t\t\t\t\t ${cost:f2}\n");
        }

        private void Reset()
        {
            //Clear topping check
            for (int i = 0; i < chkTopping.Items.Count; i++)
            {
                chkTopping.SetItemChecked(i, false);
            }

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;

            cbCrust.SelectedItem = null;
            cbSize.SelectedItem = null;
            receipt = "";
            strSoda = "";
            strWater = "";
            strSize = "";
            special = "";
            crust = "";
            strCrust = "";
            strTopping = "";
            receipt = "";

            costSize = 0;
            costSpecial = 0;
            costToping = 0;
            cost = 0;


        }

    }
}
