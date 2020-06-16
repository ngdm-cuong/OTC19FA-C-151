using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;       // xml class library

namespace _7LibraryXML
{
    public partial class Form1 : Form
    {
        int idx;                        // keep track of position in list
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlReader reader = XmlReader.Create("BooksList.xml");
            Book myBook = new Book();

            while (reader.Read())
            {
                if (reader.IsStartElement()) // is this a tag
                {
                    switch (reader.Name)    // check the name of this tag
                    {
                        case "Book":     // we are at a new Book
                            if (myBook.Title != null)    // do we have book data?
                            {
                                lstBooks.Items.Add(myBook);   // if so, add to list
                                myBook = new Book();          // create a new empty book
                            }
                            break;
                        case "Title":
                            reader.Read();  // read again to get value
                            myBook.Title = reader.Value;
                            break;
                        case "Author":      
                            reader.Read();  // read again to get value
                            myBook.Author = reader.Value;
                            break;
                        case "Subject":       
                            reader.Read();  // read again to get value
                            myBook.SubjectArea = reader.Value;
                            break;
                        case "ISBN":
                            reader.Read();  // read again to get value
                            myBook.Isbn_Number= reader.Value;
                            break;
                        case "DateAdded":
                            reader.Read();  // read again to get value
                            myBook.DateAdded = reader.Value;
                            break;
                        case "NumberOfCopies":
                            reader.Read();  // read again to get value
                            myBook.NumberOfCopiesInSystem = reader.Value;
                            break;
                        case "NumberOfCopiesCheckedOut":
                            reader.Read();  // read again to get value
                            myBook.NumberOfCopiesCheckedOut = reader.Value;
                            break;
                            // add more case logic for our other fields

                    }  // end of switch
                }  // end of if

            } // end of while
            if (myBook.Title != null)        // catch last book
            {
                lstBooks.Items.Add(myBook);
            } // end of if

            reader.Dispose();                   // clean up our reader 
        }  // end of method

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex != -1)    // has a row been clicked?
            {
                idx = lstBooks.SelectedIndex;    // yes, save the row number 

                Book aBook = (Book)lstBooks.Items[idx]; // push the row into a book object

                txtBxTitle.Text = aBook.Title;   // use the boko object to populate text boxes
                txtBxAuthor.Text = aBook.Author;
                txtBxSubject.Text = aBook.SubjectArea;
                txtBxISBN.Text = aBook.Isbn_Number;
                txtBxDateAdded.Text = aBook.DateAdded;
                txtBxNumOfCoppies.Text = aBook.NumberOfCopiesInSystem;
                txtBxNumOfCopiesCheckedOut.Text = aBook.NumberOfCopiesCheckedOut;

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex < 0)
            {
               string message = "Please choose book to check out";
               MessageBox.Show(message);
            }
            else
            {
                // instantiate a book object with the text box data
                Book aBook = new Book(txtBxTitle.Text,   // use the boko object to populate text boxes
                    txtBxAuthor.Text,
                    txtBxSubject.Text,
                    txtBxISBN.Text,
                    txtBxDateAdded.Text,
                    txtBxNumOfCoppies.Text,
                    txtBxNumOfCopiesCheckedOut.Text
                    //txtBxNumOfCopiesCheckedOut.Text
                    );
                lstBooks.Items[idx] = aBook;      // update the list box student
                aBook.CheckOutBook();
                txtBxNumOfCoppies.Text = aBook.NumberOfCopiesInSystem;
                txtBxNumOfCopiesCheckedOut.Text = aBook.NumberOfCopiesCheckedOut;

            }
           

        }


        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex < 0)
            {
                string message = "Please choose book to check in";
                MessageBox.Show(message);
            }
            else
            {
                // instantiate a book object with the text box data
                Book aBook = new Book(txtBxTitle.Text,   // use the boko object to populate text boxes
                    txtBxAuthor.Text,
                    txtBxSubject.Text,
                    txtBxISBN.Text,
                    txtBxDateAdded.Text,
                    txtBxNumOfCoppies.Text,
                    txtBxNumOfCopiesCheckedOut.Text
                    );
                lstBooks.Items[idx] = aBook;      // update the list box student
                aBook.CheckInBook();
                txtBxNumOfCoppies.Text = aBook.NumberOfCopiesInSystem;
                txtBxNumOfCopiesCheckedOut.Text = aBook.NumberOfCopiesCheckedOut;

            }
        }
    }

}// End of nameSpace
