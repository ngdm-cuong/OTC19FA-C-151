using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace ShippingG5c
{


    public partial class Form1 : Form
    {
        ArrayList Packages = new ArrayList(); // Cannot be static, and this is the temp array of packages before pushing into a real Invoice
        static int idxInvoice = 0; /// Index for the invoice created (Same with index for them in the Array)
        int idx; // ID for each Package in one Invoice
        int idx2 = 0; // ID for the Listbox2 (indicate item chosen in the listbox 2)
        bool loaded = false;
        bool invoiceCreated = false; // Check if the invoice is created yet (mainly for the first invoice that is automatically created)


        //Invoice anInvoice = new Invoice {ID = idxInvoice };


        public Form1()
        {

            InitializeComponent();
            // DataAdapter.Invoices.Add(anInvoice);
            //invoiceCreated = true;
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        /// <summary>
        /// Author: Cuong Nguyen
        /// Purpose: Push all data from the form to the object and then add to the Pacckages array
        /// Note:   aPackage.Weight  IS NEEDED TO BE EMPLEMENT
        /// Note: NEED TO DO SOMETHING FOR THE SUBTOTAL AND TAX AND TOTAL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            #region Scratch for checking all texboxes
            //foreach (TextBox tb in this.Controls.OfType<TextBox>().Where(x => x.CausesValidation == true))
            //{
            //    tb.Validating += TextBox_Validating;
            //}
            ///////////
            //foreach (Control c in this.Controls)
            //{
            //    if (c is TextBox)
            //    {
            //        TextBox textBox = c as TextBox;
            //        if (textBox.Text == string.Empty)
            //        {
            //            // Text box is empty.
            //            // You COULD store information about this textbox is it's tag.
            //        }
            //    }
            //}
            #endregion
            //DataAdapter.Invoices[idxInvoice] = anInvoice;

            //Invoice anInvoice = new Invoice();
            if (txtBxSenderName.Text == "") // Constraint for sender box
                MessageBox.Show("Sender Name CANNOT be empty!");
            else
            {
                if (rbOverNight.Checked == true)
                {
                    OverNight aPackage = new OverNight();
                    aPackage.RecipientName = txtBxRecipientName.Text;
                    aPackage.RecipientAddress = txtBxRecipientAddress.Text;
                    aPackage.RecipientCity = txtBxRecipientAddress.Text;
                    aPackage.RecipientState = txtBxRecipientState.Text;
                    aPackage.RecipientZipCode = txtBxRecipientZipCode.Text;

                    aPackage.SenderName = txtBxSenderName.Text;
                    aPackage.SenderAddress = txtBxSenderAddress.Text;
                    aPackage.SenderCity = txtBxSenderCity.Text;
                    aPackage.SenderState = txtBxSenderState.Text;
                    aPackage.SenderZipCode = txtBxSenderZipCode.Text;
                    // This one is to get the checked shipping company
                    for (int i = 0; i <= (chShipCompany.Items.Count - 1); i++)
                    {
                        if (chShipCompany.GetItemChecked(i))
                        {
                            aPackage.ShippingCompany = chShipCompany.Items[i].ToString();
                        }
                    }
                    aPackage.ShippingMethod = "Over Night";
                    aPackage.Weight = Convert.ToDecimal(textBox1.Text);
                    ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
                    aPackage.CostPerOunce = service.GetCost(aPackage.ShippingCompany);
                    aPackage.Cost =  aPackage.CalculateCost();
                    ClearTextBoxes();
                    listBox1.Items.Clear();
                    //listBox1.Items.Add(aPackage);
                    //anInvoice.Packages.Add(aPackage);
                    Packages.Add(aPackage);
                    foreach (var item in Packages)
                    {
                        listBox1.Items.Add(item);
                    }
                    Console.WriteLine(aPackage);
                }
                // Automatic become TwoDay Shiping if user does not state which kind of method shipping they want to chose 
                else
                {
                    TwoDay aPackage = new TwoDay();
                    aPackage.RecipientName = txtBxRecipientName.Text;
                    aPackage.RecipientAddress = txtBxRecipientAddress.Text;
                    aPackage.RecipientCity = txtBxRecipientAddress.Text;
                    aPackage.RecipientState = txtBxRecipientState.Text;
                    aPackage.RecipientZipCode = txtBxRecipientZipCode.Text;

                    aPackage.SenderName = txtBxSenderName.Text;
                    aPackage.SenderAddress = txtBxSenderAddress.Text;
                    aPackage.SenderCity = txtBxSenderCity.Text;
                    aPackage.SenderState = txtBxSenderState.Text;
                    aPackage.SenderZipCode = txtBxSenderZipCode.Text;
                    // This one is to get the checked shipping company
                    for (int i = 0; i <= (chShipCompany.Items.Count - 1); i++)
                    {
                        if (chShipCompany.GetItemChecked(i))
                        {
                            aPackage.ShippingCompany = chShipCompany.Items[i].ToString();
                        }
                    }
                    aPackage.ShippingMethod = "Two Day";
                    aPackage.Weight = Convert.ToDecimal(textBox1.Text);
                    ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
                    aPackage.CostPerOunce = service.GetCost(aPackage.ShippingCompany);
                    aPackage.Cost = aPackage.CalculateCost();
                    ClearTextBoxes();
                    listBox1.Items.Clear();
                    //listBox1.Items.Add(aPackage);
                    //anInvoice.Packages.Add(aPackage);
                    Packages.Add(aPackage);
                    foreach (var item in Packages)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }



        } // END OF ADD METHOD
        /// <summary>
        /// Author: Cuong Nguyen
        /// Purpose: Fill in data in the boxes base on what item you choose from the listbox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Add.Visible = false;
            button5.Visible = true;
            Delete.Visible = true;
            if (listBox1.SelectedIndex != -1)
            {

                idx = listBox1.SelectedIndex;
                //Invoice  tmpInvoice = (Invoice)DataAdapter.Invoices[idxInvoice];
                //Package tmpPackage = (Package)tmpInvoice.Packages[idx];
                Package tmpPackage = (Package)Packages[idx];

                txtBxRecipientName.Text = tmpPackage.RecipientName;
                txtBxRecipientAddress.Text = tmpPackage.RecipientAddress;
                txtBxRecipientAddress.Text = tmpPackage.RecipientCity;
                txtBxRecipientState.Text = tmpPackage.RecipientState;
                txtBxRecipientZipCode.Text = tmpPackage.RecipientZipCode;

                txtBxSenderName.Text = tmpPackage.SenderName;
                txtBxSenderAddress.Text = tmpPackage.SenderAddress;
                txtBxSenderCity.Text = tmpPackage.SenderCity;
                txtBxSenderState.Text = tmpPackage.SenderState;
                txtBxSenderZipCode.Text = tmpPackage.SenderZipCode;
                // This one is to get the checked shipping company
                if (tmpPackage.ShippingCompany == "Fedex")
                {
                    chShipCompany.SetItemCheckState(0, CheckState.Checked);
                }
                else if (tmpPackage.ShippingCompany == "UPS")
                {
                    chShipCompany.SetItemCheckState(1, CheckState.Checked);
                }
                else { chShipCompany.SetItemCheckState(2, CheckState.Checked); }


                if (tmpPackage.ShippingMethod == "Two Day")
                {
                    rbTwoDay.Checked = true;
                }
                else
                {
                    rbOverNight.Checked = true;
                }
                textBox1.Text = tmpPackage.Weight.ToString();

            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (loaded == false)
            {

                // DataAdapter.Get();
                //foreach (Package item in Invoice.Packages)
                //{
                //    listBox1.Items.Add(item);
                //    loaded = true;
                //    //Console.WriteLine(item);
                //}
            }
            else
            {
                MessageBox.Show("You already load the data");
            }

        }

        /// <summary>
        /// CuongNguyen
        /// Serilazie Data and send to DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveInvoices_Click(object sender, EventArgs e)
        {
            Invoice myInvoice = new Invoice();
            string data = "";
            foreach (Invoice item in DataAdapter.Invoices)
            {
                data += $"Invoice({item}) : ";
                foreach (var pkg in item.Packages)
                {
                    data += pkg; 
                }
                data += "\n";
            }
            Console.WriteLine(data);
           // Serializer.SerializeNow(myInvoice); // To Serialize the selected invoice and send them to DB

            //call the DB Get method to get all the records
            //DataAdapter.Get();
        }
        #region Cuong DEFINE for ClearTextBoxese
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
            chShipCompany.SetItemCheckState(0, CheckState.Unchecked);
            chShipCompany.SetItemCheckState(1, CheckState.Unchecked);
            chShipCompany.SetItemCheckState(2, CheckState.Unchecked);
            rbOverNight.Checked = false;
            rbTwoDay.Checked = false;
            textBox1.Text = "";
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox currenttb = (TextBox)sender;
            if (currenttb.Text == "")
            {
                MessageBox.Show(string.Format("Empty field {0 }", currenttb.Name.Substring(3)));
                e.Cancel = true;
            }

            else
            {
                e.Cancel = false;
            }
        }

        #endregion
        /// <summary>
        /// Developer: Cuong Nguyen
        /// Purpose: Create invoices from  the packages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Invoice anInvoice = new Invoice
            {
                ID = idxInvoice
            };
            anInvoice.Packages = (ArrayList)Packages.Clone();
            if (invoiceCreated == true)
            {

                listBox2.Items.Clear();
                invoiceCreated = false;

                foreach (var item in DataAdapter.Invoices)
                {
                    listBox2.Items.Add(item);
                    Console.WriteLine(item);

                }
                Packages.Clear();
            }
            else
            {
                anInvoice.CalculateTax();
                anInvoice.CalculateTotal();
                DataAdapter.Invoices.Add(anInvoice);
                listBox2.Items.Clear();

                foreach (Invoice item in DataAdapter.Invoices)
                {
                    listBox2.Items.Add("Invoice("+item.ID+")");
                    //Console.WriteLine(item);

                }
                Packages.Clear();
            }

            idxInvoice++;
        }
        /// <summary>
        /// Developer: Cuong Nguyen
        /// Purpose: Show Packages info in the first tab with each invoice user chooses in the Invoice Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox2.SelectedIndex != -1)
            {

                idx2 = listBox2.SelectedIndex;
                Invoice tmpInvoice = (Invoice)DataAdapter.Invoices[idx2];
                Packages = (ArrayList)tmpInvoice.Packages;
                listBox3.Items.Clear();
                foreach (var item in Packages)
                {
                    listBox3.Items.Add(item);
                }
                txbxSubTotal.Text = tmpInvoice.subTotal.ToString();
                txbxTax.Text = tmpInvoice.TaxTotal.ToString();
                txbxtotal.Text = tmpInvoice.TotalCost.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            btnCreateInvoice.Visible = false;
            if (listBox2.SelectedIndex != -1)
            {

                idx2 = listBox2.SelectedIndex;
                Invoice tmpInvoice = (Invoice)DataAdapter.Invoices[idx2];
                Packages = (ArrayList)tmpInvoice.Packages;
                listBox1.Items.Clear();
                foreach (var item in Packages)
                {
                    listBox1.Items.Add(item);
                }

            }
            tabPage1.Show();
        }
        /// <summary>
        /// print invoices 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string packageInfo = "";
            string cost = "";
            idx2 = listBox2.SelectedIndex;
            Invoice tmpInvoice = (Invoice)DataAdapter.Invoices[idx2];
            foreach (Package tmpPackage in tmpInvoice.Packages)
            {
                packageInfo += "Sender Information:\n";
                packageInfo += "Name: "+ tmpPackage.SenderName + "\n";
                packageInfo += "Address: "+tmpPackage.SenderAddress + "\n";
                packageInfo += tmpPackage.SenderCity + tmpPackage.SenderState + ", " + tmpPackage.SenderZipCode + "\n";
                packageInfo += "Recipent Information:\n";
                packageInfo += "Name: " + tmpPackage.RecipientName + "\n";
                packageInfo += "Address: " + tmpPackage.RecipientAddress + "\n";
                packageInfo += tmpPackage.RecipientCity + tmpPackage.RecipientState + ", " + tmpPackage.RecipientZipCode + "\n";
                packageInfo += "------------\n";
                packageInfo += "Shipping Company: "+tmpPackage.ShippingCompany+"\n";
                packageInfo += "Shipping Method: " + tmpPackage.ShippingMethod + "\n";
                packageInfo += "------------\n";
                packageInfo += "Weight: "+ tmpPackage.Weight + "oz\n";
                packageInfo += "Cost: $" + tmpPackage.Cost + "\n\n";
            }
            cost = tmpInvoice.ToString();
            PrintInvoice thing = new PrintInvoice(packageInfo,cost);
            thing.Show();
        }
        /// <summary>
        /// print label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string shipInfo ="";
            string RecevierInfo ="";
            if (listBox1.SelectedIndex != -1)
            {

                idx = listBox1.SelectedIndex;
                //Invoice  tmpInvoice = (Invoice)DataAdapter.Invoices[idxInvoice];
                //Package tmpPackage = (Package)tmpInvoice.Packages[idx];
                Package tmpPackage = (Package)Packages[idx];
            
                shipInfo += tmpPackage.SenderName + "\n";
                shipInfo += tmpPackage.SenderAddress + "\n";
                shipInfo += tmpPackage.SenderCity + tmpPackage.SenderState +", "+tmpPackage.SenderZipCode+"\n";
                RecevierInfo += tmpPackage.RecipientName + "\n";
                RecevierInfo += tmpPackage.RecipientAddress+ "\n";
                RecevierInfo += tmpPackage.RecipientCity + tmpPackage.RecipientState + ", " + tmpPackage.RecipientZipCode + "\n";



                PrintLabel label = new PrintLabel(tmpPackage.ShippingCompany,
                    tmpPackage.ShippingMethod,
                    tmpPackage.Weight, shipInfo, RecevierInfo);
                    
                    
                label.Show();


            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            double value = 0;
            if (!double.TryParse(textBox1.Text + e.KeyChar.ToString(), out value) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id= listBox1.SelectedIndex;
            Packages.RemoveAt(id);
            listBox1.Items.Clear();
            
            foreach (var item in Packages)
            {
                listBox1.Items.Add(item);
            }
            ClearTextBoxes();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int id = listBox1.SelectedIndex;
          
            
                if (rbOverNight.Checked == true)
                {
                    OverNight aPackage = new OverNight();
                    aPackage.RecipientName = txtBxRecipientName.Text;
                    aPackage.RecipientAddress = txtBxRecipientAddress.Text;
                    aPackage.RecipientCity = txtBxRecipientAddress.Text;
                    aPackage.RecipientState = txtBxRecipientState.Text;
                    aPackage.RecipientZipCode = txtBxRecipientZipCode.Text;

                    aPackage.SenderName = txtBxSenderName.Text;
                    aPackage.SenderAddress = txtBxSenderAddress.Text;
                    aPackage.SenderCity = txtBxSenderCity.Text;
                    aPackage.SenderState = txtBxSenderState.Text;
                    aPackage.SenderZipCode = txtBxSenderZipCode.Text;
                    // This one is to get the checked shipping company
                    for (int i = 0; i <= (chShipCompany.Items.Count - 1); i++)
                    {
                        if (chShipCompany.GetItemChecked(i))
                        {
                            aPackage.ShippingCompany = chShipCompany.Items[i].ToString();
                        }
                    }
                    aPackage.ShippingMethod = "Over Night";
                    aPackage.Weight = Convert.ToDecimal(textBox1.Text);
                    ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
                    aPackage.CostPerOunce = service.GetCost(aPackage.ShippingCompany);
                aPackage.Cost = aPackage.CalculateCost();
                    ClearTextBoxes();
                    listBox1.Items.Clear();
                //listBox1.Items.Add(aPackage);
                //anInvoice.Packages.Add(aPackage);
                Packages[id] = aPackage;


            }
                // Automatic become TwoDay Shiping if user does not state which kind of method shipping they want to chose 
                else
                {
                    TwoDay aPackage = new TwoDay();
                    aPackage.RecipientName = txtBxRecipientName.Text;
                    aPackage.RecipientAddress = txtBxRecipientAddress.Text;
                    aPackage.RecipientCity = txtBxRecipientAddress.Text;
                    aPackage.RecipientState = txtBxRecipientState.Text;
                    aPackage.RecipientZipCode = txtBxRecipientZipCode.Text;

                    aPackage.SenderName = txtBxSenderName.Text;
                    aPackage.SenderAddress = txtBxSenderAddress.Text;
                    aPackage.SenderCity = txtBxSenderCity.Text;
                    aPackage.SenderState = txtBxSenderState.Text;
                    aPackage.SenderZipCode = txtBxSenderZipCode.Text;
                    // This one is to get the checked shipping company
                    for (int i = 0; i <= (chShipCompany.Items.Count - 1); i++)
                    {
                        if (chShipCompany.GetItemChecked(i))
                        {
                            aPackage.ShippingCompany = chShipCompany.Items[i].ToString();
                        }
                    }
                    aPackage.ShippingMethod = "Two Day";
                    aPackage.Weight = Convert.ToDecimal(textBox1.Text);
                    ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
                    aPackage.CostPerOunce = service.GetCost(aPackage.ShippingCompany);
                aPackage.Cost = aPackage.CalculateCost();
                    ClearTextBoxes();
                 Packages[id] = aPackage;
                }
            listBox1.Items.Clear();
             foreach (var item in Packages)
            {
                listBox1.Items.Add(item);
            }
            Add.Visible = true;
            button5.Visible = false;
            Delete.Visible = false;



        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int id = listBox2.SelectedIndex;
            DataAdapter.Invoices.RemoveAt(id);
            listBox2.Items.Clear();
            foreach(Invoice i in DataAdapter.Invoices)
            {
                listBox2.Items.Add(i);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int id = listBox2.SelectedIndex;
            Invoice anInvoice = new Invoice
            {
                ID = idxInvoice
            };
            anInvoice.Packages = (ArrayList)Packages.Clone();
             anInvoice.CalculateTax();
                anInvoice.CalculateTotal();
            DataAdapter.Invoices[id] = anInvoice;
                listBox2.Items.Clear();

                foreach (Invoice item in DataAdapter.Invoices)
                {
                    listBox2.Items.Add("Invoice("+item.ID+")");
                 

                }
                Packages.Clear();
            

            idxInvoice++;
        }
    }
}// End of name space
