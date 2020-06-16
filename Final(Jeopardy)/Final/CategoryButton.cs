using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
namespace Final
{
    class CategoryButton : Button
    {
        public ArrayList Categories { get; set; }

        public CategoryButton()
        {
            Categories = new ArrayList();
        }
        public override string ToString()
        {
            return this.Text;
        }
    }
}
