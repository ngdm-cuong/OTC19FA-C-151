using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Final
{
    class Category : Button
    {
       // #region OLD 
       // public static List<Category> Categories;
       // //public static ArrayList Categories = new ArrayList(); // Contain all the categories  
       // #region Private data field
       // private string categoryName;
       // private List<Question> question;
       // //private ArrayList questions = new ArrayList();                  
       // #endregion
       // #region Public properties
       // public string CategoryName { get => categoryName; set => categoryName = value; }
       //// public ArrayList Questions { get => questions; set => questions = value; }
       // public List<Question> Questions { get => question; set => question = value; }
       // #endregion
       // public Category() { }

       // public override string ToString()
       // {
       //     return this.Text;
       // }
       // #endregion

        public ArrayList Questions { get; set; }
        public string CategoryName { get; set; }
        public Category()
        {
            Questions = new ArrayList();
        }
        public override string ToString()
        {
            return this.Text    ;
        }
    }
}
