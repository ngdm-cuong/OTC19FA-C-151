using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3ExamEmpSys
{
    public partial class Form1 : Form
    {
        bool loaded = false; // Check to see if the program has connected and loaded the database yet.
        bool AddNewState = false;
        int idx;
        public Form1()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            btnAddnew.Enabled = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (loaded == false)
            {
                txtBxID.Enabled = false;
                txtBxEmployeeID.Enabled = false;
                btnAddnew.Enabled = true;
                DataAdapter.Get();
                foreach (FullTime item in DataAdapter.FullTimeEmployees)
                {
                    listBox1.Items.Add(item);
                    loaded = true;
                    //Console.WriteLine(item);
                }
            }
            else
            {
                MessageBox.Show("You already load the data");
            }
               
        }
        /// <summary>
        /// Purpose: Dissconect to update data if a row is just deleted. 
                    // Recreate the FulltimeEmployee Arraylist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            loaded = false;
            DataAdapter.Disconnect();
            listBox1.Items.Clear();
            DataAdapter.FullTimeEmployees.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex !=-1)
            {
                btnInsert.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                // These two enabled function is for us to not duplicate data in the database. 
                // For example you can not just click on an exist data and do INSERT them to the database
                // The only option you have is only to Update data if you click on the list
                idx = listBox1.SelectedIndex;
                FullTime aFullTime = (FullTime)DataAdapter.FullTimeEmployees[idx];

                txtBxEmployeeID.Text = aFullTime.ID.ToString();
                txtBxFName.Text = aFullTime.FirstNanme;
                txtBxLName.Text = aFullTime.LastName;
                txtBxDateHired.Text = aFullTime.DateHired.ToString();
                txtBxSSN.Text = aFullTime.SSN;
                txtBxEmail.Text = aFullTime.Email;
                txtBxPhone.Text = aFullTime.Phone;
                txtBxTaxRate.Text = aFullTime.TaxRate.ToString();
                txtBxID.Text = aFullTime.ID.ToString();
                txtBxSalary.Text = aFullTime.Salary.ToString();
                numBxVacationDays.Text = aFullTime.NumOfVacationDays.ToString();
                txtBxHasInsurance.Text = aFullTime.HasInsurance;
                txtBxTaxExempt.Text = aFullTime.TaxExempt;
                numBxSickDays.Text = aFullTime.NumOfSickDays.ToString();


            }
        }
        /// <summary>
        /// Purpose: Check on condition before insert data to the database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click_1(object sender, EventArgs e)
        {

            FullTime aFullTime = new FullTime();

            if (Convert.ToInt16(txtBxEmployeeID.Text) <= DataAdapter.FullTimeEmployees.Count)
            {
                MessageBox.Show("This ID has been taken!");
            }
           else if(!Decimal.TryParse(txtBxTaxRate.Text,out decimal number) || txtBxTaxRate.Text=="")
            {
                MessageBox.Show("Please Enter TaxRate to check out");
            }
            else if (!Decimal.TryParse(txtBxSalary.Text, out decimal salary) || txtBxSalary.Text == "")
            {
                MessageBox.Show("Please Enter Salary to check out");
            }
            else if (numBxVacationDays.Text=="")
            {
                MessageBox.Show("Please Enter TaxRate to check out");
            }
            else if (numBxSickDays.Text=="" )
            {
                MessageBox.Show("Please Enter TaxRate to check out");
            }
            else
            {

                aFullTime.ID = Convert.ToInt16(txtBxEmployeeID.Text);
                aFullTime.FirstNanme = txtBxFName.Text;
                aFullTime.LastName = txtBxLName.Text;
                aFullTime.DateHired = Convert.ToDateTime(txtBxDateHired.Text);
                aFullTime.SSN = txtBxSSN.Text;
                aFullTime.Email = txtBxEmail.Text;
                aFullTime.Phone = txtBxPhone.Text;
                aFullTime.TaxRate = Convert.ToDecimal(txtBxTaxRate.Text);
                aFullTime.ID = Convert.ToInt16(txtBxID.Text);
                aFullTime.Salary = Convert.ToDecimal(txtBxSalary.Text);
                aFullTime.NumOfVacationDays = Convert.ToInt16(numBxVacationDays.Text);
                aFullTime.HasInsurance = txtBxHasInsurance.Text;
                aFullTime.TaxExempt = txtBxTaxExempt.Text;
                aFullTime.NumOfSickDays = Convert.ToInt16(numBxSickDays.Text);

                DataAdapter.Insert(aFullTime);

                listBox1.Items.Clear();
                DataAdapter.FullTimeEmployees.Add(aFullTime);
                foreach (FullTime item in DataAdapter.FullTimeEmployees)
                {
                    listBox1.Items.Add(item);
                    loaded = true;

                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FullTime aFullTime = new FullTime();

            aFullTime.ID = Convert.ToInt16(txtBxEmployeeID.Text);
            aFullTime.FirstNanme = txtBxFName.Text;
            aFullTime.LastName = txtBxLName.Text;
            aFullTime.DateHired = Convert.ToDateTime(txtBxDateHired.Text);
            aFullTime.SSN = txtBxSSN.Text;
            aFullTime.Email = txtBxEmail.Text;
            aFullTime.Phone = txtBxPhone.Text;
            aFullTime.TaxRate = Convert.ToDecimal(txtBxTaxRate.Text);
            aFullTime.ID = Convert.ToInt16(txtBxID.Text);
            aFullTime.Salary = Convert.ToDecimal(txtBxSalary.Text);
            aFullTime.NumOfVacationDays = Convert.ToInt16(numBxVacationDays.Text);
            aFullTime.HasInsurance = txtBxHasInsurance.Text;
            aFullTime.TaxExempt = txtBxTaxExempt.Text;
            aFullTime.NumOfSickDays = Convert.ToInt16(numBxSickDays.Text);

            DataAdapter.Update(aFullTime);

            listBox1.Items.Clear();
            DataAdapter.FullTimeEmployees[idx] = aFullTime;
            foreach (FullTime item in DataAdapter.FullTimeEmployees)
            {
                listBox1.Items.Add(item);
                loaded = true;

            }
        }
        /// <summary>
        /// Purpose: Delete from Database based on current ID  ==> Disconect ==> Clear Array ==> ReLoad Data and the list to From and array  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
           // listBox1.Items.Clear();
            DataAdapter.Delete(Convert.ToInt16(txtBxID.Text));
            DataAdapter.Disconnect();
            loaded = false;
            listBox1.Items.Clear();
            DataAdapter.FullTimeEmployees.Clear();
            if (loaded == false)
            {
                txtBxID.Enabled = false;
                txtBxEmployeeID.Enabled = false;
                btnAddnew.Enabled = true;
                DataAdapter.Get();
                foreach (FullTime item in DataAdapter.FullTimeEmployees)
                {
                    listBox1.Items.Add(item);
                    loaded = true;
                    //Console.WriteLine(item);
                }
            }
            else
            {
                MessageBox.Show("You already load the data");
            }

        }

        private void BtnAddnew_Click(object sender, EventArgs e)
        {
            numBxVacationDays.Value = 0;
            numBxSickDays.Minimum = 0;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            ClearTextBoxes();
            AddNewState = true;
            txtBxID.Text = Convert.ToString(DataAdapter.FullTimeEmployees.Count + 1);
            txtBxEmployeeID.Text = Convert.ToString(DataAdapter.FullTimeEmployees.Count + 1);
            txtBxID.Enabled = false;
            txtBxEmployeeID.Enabled = false;
        }// End of Btn Addnew
        #region USER DEFINE
        /// <summary>
        /// Purpose: Clear all Tex Boxes
        /// </summary>
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        #endregion
        private void txtBxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBxTaxRate_TextChanged(object sender, EventArgs e)
        {
            string tString = txtBxTaxRate.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!(char.IsNumber(tString[i]) || (tString[i] == '.')))
                {
                    MessageBox.Show("Invalid cost amount");
                    txtBxTaxRate.Text = "";
                    txtBxTaxRate.Focus();
                }
            }
        }
    }// End of mainclass
}// End of namespace
