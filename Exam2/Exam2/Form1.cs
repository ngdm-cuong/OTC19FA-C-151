using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;// xml class library

namespace Exam2
{
    public partial class Form1 : Form
    {
        int idx; // Keep track of how many slot has been used
        ArrayList checkoutList = new ArrayList();  //////////////////////////// To store tickets that are already checked out
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBxTicketNumber.Enabled = false;
            txtBxTicketNumber.Text = "";
        }  // end of method

        private void radBtnCheckOut_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnCheckIn.Checked == true)
            {
                txtBxTicketNumber.Enabled = false;
                txtBxTicketNumber.Text = "";
            }
            else
                txtBxTicketNumber.Enabled = true;
        }
        /// <summary>
        /// Purpose : Issue ticket and check if the garage is full or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            int availableSlot = AvailableSlot();
            string message;
            if (radBtnCheckIn.Checked == true && IsGarageFull())
            {
                // instantiate a student object with the text box data
                Ticket aTicket = new Ticket();
                aTicket.TicketNo = idx.ToString();
               // TimeSpan timeNow = DateTime.Now.TimeOfDay;
               // TimeSpan trimmedTimeNow = new TimeSpan(timeNow.Hours, timeNow.Minutes, timeNow.Seconds); // Get time if format (get rid of the milliseconds)

                aTicket.TimeIn = DateTime.Now;

                Ticket.Garage[availableSlot] = (true);
                Ticket.TicketArray[availableSlot] = aTicket;
                lblTicketIssue.Text = $"Your Ticket number: #{idx}";

                idx++; /////////////////////////////////////////////////////////////////////////////////////// Create number for the next ticket
                // establish our xml writer settings
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.NewLineHandling = NewLineHandling.Replace;
                // the using clause is important. all resources needed by the using will
                // be de-allocated at the end of the using block
                using (XmlWriter writer = XmlWriter.Create("Tickets.xml", settings))
                {
                    writer.WriteStartDocument();                            // write the xml header
                    writer.WriteStartElement("Tickets");                   // write our root tag
                    for (int i = 0; i < Ticket.TicketArray.Length; i++)
                    {
                        if (Ticket.TicketArray[i] != null)
                        {
                            writer.WriteStartElement("Ticket");// write a Ticket tag
                            writer.WriteElementString("TicketNo", Ticket.TicketArray[i].TicketNo);     // add Ticket fields
                            writer.WriteElementString("TimeIn", Ticket.TicketArray[i].TimeIn.ToString());
                            //writer.WriteElementString("TimeOut", aTicket.TimeOut.ToString());
                            writer.WriteEndElement();
                        }

                    }
                }
                ListUpdate();

            }
            else if (radBtnCheckIn.Checked == false)
            {
                message = ("Please check on the \"Check in\" box to check in");
                MessageBox.Show(message);
            }
            else
            {
                message = ("Garage Full");
                MessageBox.Show(message);
            }

        }// End of Issue Button Method

        /// <summary>
        /// Purpose : Update the list of tickets after customers check in or out 
        /// </summary>
        private void ListUpdate()
        {
            lstBxIssuedTicket.Items.Clear();
            XmlReader reader = XmlReader.Create("Tickets.xml");
            Ticket my_Ticket = new Ticket();
            while (reader.Read())
            {
                if (reader.IsStartElement()) // is this a tag
                {
                    switch (reader.Name)    // check the name of this tag
                    {
                        case "Ticket":     // we are at a new ticket
                            if (my_Ticket.TicketNo != null)    // do we have ticket data?
                            {
                                lstBxIssuedTicket.Items.Add(my_Ticket);   // if so, add to list
                                my_Ticket = new Ticket();          // create a new empty ticket
                            }
                            break;
                        case "TicketNo":
                            reader.Read();  // read again to get value
                            my_Ticket.TicketNo = reader.Value;
                            break;
                        case "TimeIn":
                            // string stringTime = my_Ticket.TimeIn.ToString("h:mm:ss tt");
                            reader.Read();  // read again to get value
                            string stringTime = reader.Value;
                            my_Ticket.TimeIn = DateTime.Parse(stringTime);
                            break;

                            // add more case logic for our other fields

                    }  // end of switch
                }  // end of if

            } // end of while
            if (my_Ticket.TicketNo != null)        // catch last ticket
            {
                lstBxIssuedTicket.Items.Add(my_Ticket);
            } // end of if

            reader.Dispose();                   // clean up our reader 
        }// End of ListUpdate Method
        /// <summary>
        /// Purpose: Check to see if the location in the ticket array is available , then put the new ticket in that location, so we dont have to loop through the whole array
        /// </summary>
        /// <returns></returns>
        private static int AvailableSlot()
        {
            int SlotCount;
            for (SlotCount = 0; SlotCount < Ticket.Garage.Length; SlotCount++)
            {
                if (Ticket.Garage[SlotCount] == false)
                {
                    break;
                }
            }
            return SlotCount;
        }
        /// <summary>
        /// Check out tickets and check to see if that ticket is valid to check out 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int availableSlot = AvailableSlot();
            string message;
            int ticketOut;// index of the ticket you want to check out in TicketArray[]


            if (radBtnCheckOut.Checked == false)
            {
                message = ("Please check on the \"Check OUT\" box to check in");
                MessageBox.Show(message);
            }
            else if (!Int32.TryParse(txtBxTicketNumber.Text, out int number) || txtBxTicketNumber.Text == "")
                MessageBox.Show("Please Enter YourTicket number to check out");
            //!Int32.TryParse(txtBxTicketNumber.Text, out int number)
            else
            {
                // instantiate a student object with the text box data

                if (number >= idx || number < 0 || IfCheckedOut(number))
                {

                    MessageBox.Show("Cannot find this ticket number in the system.\nPlease try again.");
                }
                else
                {
                    Ticket aTicket = new Ticket();
                    aTicket.TicketNo = txtBxTicketNumber.Text;
                    //DateTime timeNow = DateTime.Now.AddHours(24).AddMinutes(15).TimeOfDay;
                    // TimeSpan trimmedTimeNow = new TimeSpan(timeNow.Hours, timeNow.Minutes, timeNow.Seconds); // Get time if format (get rid of the milliseconds)
                    aTicket.TimeOut = DateTime.Now;
                    //aTicket.TimeOut = DateTime.Now.AddHours(25).AddMinutes(59);

                    for (ticketOut = 0; ticketOut < Ticket.TicketArray.Length; ticketOut++)
                    {
                        if (Ticket.TicketArray[ticketOut] != null)
                        {
                            if (Ticket.TicketArray[ticketOut].TicketNo == aTicket.TicketNo)
                                break;
                        }
                    }
                    Ticket.TicketArray[ticketOut].TimeOut = aTicket.TimeOut;
                    decimal chargeAmount = Ticket.CalculateCharege(Ticket.TicketArray[ticketOut].TimeIn, Ticket.TicketArray[ticketOut].TimeOut);
                    MessageBox.Show($"Check Out Ticket #{Ticket.TicketArray[ticketOut].TicketNo}\n" +
                        $"Time In:     {Ticket.TicketArray[ticketOut].TimeIn}\n" +
                        $"Time Out: {Ticket.TicketArray[ticketOut].TimeOut}\n" +
                        $"Charge amount: {chargeAmount:C}");

                    checkoutList.Add(number);
                    /// Delete Ticket from Garage and TicketArray
                    Ticket.Garage[ticketOut] = (false);
                    Ticket.TicketArray[ticketOut] = null;//// 
                    #region XML Writer
                    // establish our xml writer settings
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    settings.NewLineHandling = NewLineHandling.Replace;
                    using (XmlWriter writer = XmlWriter.Create("Tickets.xml", settings))
                    {
                        writer.WriteStartDocument();                            // write the xml header
                        writer.WriteStartElement("Tickets");                   // write our root tag
                        for (int i = 0; i < Ticket.TicketArray.Length; i++)
                        {
                            if (Ticket.TicketArray[i] != null)
                            {
                                writer.WriteStartElement("Ticket");// write a Ticket tag
                                writer.WriteElementString("TicketNo", Ticket.TicketArray[i].TicketNo.ToString());     // add Ticket fields
                                writer.WriteElementString("TimeIn", Ticket.TicketArray[i].TimeIn.ToString());
                                writer.WriteElementString("TimeOut", aTicket.TimeOut.ToString());
                                writer.WriteEndElement();
                            }

                        }
                    }
                    #endregion
                    ListUpdate();
                }//End of Else

            }
            txtBxTicketNumber.Text = "";
        }// enmd of checkout button
        /// <summary>
        /// Purpose: Check to see if that ticket number is checked out already or not.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool IfCheckedOut(int number)
        {
            bool status = false;
            foreach (int checkedOut in checkoutList)
            {
                if (checkedOut == number)
                {
                    status = true;
                    break;
                }
                else
                    status = false;
            }

            return status;
        }// End of  IfCheckedOut
        /// <summary>
        /// Purpose: check to see if the garage is complete full or not.
        /// </summary>
        /// <returns></returns>
        private bool IsGarageFull()
        {
            bool status= false;

            for (int i = 0; i < Ticket.Garage.Length; i++)
            {
                if (Ticket.Garage[i] == false)
                {
                    status = true;
                    break;
                }
                else
                    status = false;
            }
            return status;
        }
    }// End of class
}//end of name space
