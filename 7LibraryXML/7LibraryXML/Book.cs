using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7LibraryXML
{
    class Book
    {
        #region Data Fields
        private string title;
        private string author;
        private string subjectArea;
        private string isbn_Number;
        private string dateAdded;
        private string numberOfCopiesInSystem;
        private string numberOfCopiesCheckedOut;


        #endregion
        #region Public properties
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string SubjectArea { get => subjectArea; set => subjectArea = value; }
        public string Isbn_Number { get => isbn_Number; set => isbn_Number = value; }
        public string DateAdded { get => dateAdded; set => dateAdded = value; }
        public string NumberOfCopiesInSystem { get => numberOfCopiesInSystem; set => numberOfCopiesInSystem = value; }
        public string NumberOfCopiesCheckedOut { get => numberOfCopiesCheckedOut; set => numberOfCopiesCheckedOut = value; }

        #endregion
        #region Constructors

        public Book() { }

        public Book(string title, string author, string subjectArea, string isbn_Number, string dateAdded, string numberOfCopiesInSystem, string numberOfCopiesCheckedOut)
        {
            this.title = title;
            this.author = author;
            this.subjectArea = subjectArea;
            this.isbn_Number = isbn_Number;
            this.dateAdded = dateAdded;
            this.numberOfCopiesInSystem = numberOfCopiesInSystem;
            this.numberOfCopiesCheckedOut = numberOfCopiesCheckedOut;
        }
        #endregion
        #region Methods
        private bool IsCopyAvailable()
        {
            int x = Int32.Parse(numberOfCopiesInSystem);
            bool status = false;
            if (x > 0)
                status = true;
            return status;
        }
        public void CheckOutBook()
        {
            int x = Int32.Parse(numberOfCopiesInSystem);
            int y = Int32.Parse(numberOfCopiesCheckedOut);
            string message;
            if (x>0)
            {
                x--;
                y++;
                DateTime dt = DateTime.Now;
                dt = dt.AddDays(14);
                string dtString = dt.ToString("dd MMMM yyyy");
                message = ("Please return the book by " + dtString);
                MessageBox.Show(message);
            }
 
            else
            {
                message = "Sorry, this book is not available at the moment.";
                MessageBox.Show(message);
            }


            numberOfCopiesInSystem = x.ToString();
            numberOfCopiesCheckedOut = y.ToString();

        }
        public void CheckInBook()
        {
            int x = Int32.Parse(numberOfCopiesInSystem);
            int y = Int32.Parse(numberOfCopiesCheckedOut);
            string message;
            if (y > 0)
            {
                x++;
                y--;
                DateTime dt = DateTime.Now;
                DateTime due = dt.AddDays(14);
               // DateTime due = dt.AddDays(-30); // For testing
                string dueString = due.ToString("dd MMMM yyyy");
                if (dt < due)
                {
                    message = ("Thank you for returning the book before the due \n" + dueString);
                    MessageBox.Show(message);
                }
                else
                {
                    double dateLate;
                    dateLate = (dt - due).TotalDays;
                    message = ($"Sorry, we have to charge you ${dateLate} for the late return of {dateLate} day(s).\n" + "Due day: " + dueString);
                    MessageBox.Show(message);
                }
            }

            else
            {
                message = ($"You did not borrow this book!");
                MessageBox.Show(message);
            }
            numberOfCopiesInSystem = x.ToString();
            numberOfCopiesCheckedOut = y.ToString();

        }
        public override string ToString()
        {
            return Title + "," + Author + "," + SubjectArea + "," + Isbn_Number + "," + dateAdded + "," + NumberOfCopiesInSystem;
        }

        #endregion
    }
}
