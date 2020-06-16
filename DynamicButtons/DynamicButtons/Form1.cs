using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayQuestions();
        }
        public void displayQuestions()
        {

            for (int i = 0; i < 30; i++)
            {
                int x = 25 + i / 6 * 148;
                int y = 47 + i%6 * 65;
                if (y > 47 + 65 * 5)
                {
                    
                    Button button = new Button();
                    button.Location = new System.Drawing.Point(x, y);
                    button.Margin = new System.Windows.Forms.Padding(4);
                    button.Text = ""+i;
                    button.Size = new System.Drawing.Size(140, 31);
                    this.Controls.Add(button);
                }
                else
                {
                    Button button = new Button();
                    button.Location = new System.Drawing.Point(x, y);
                    button.Margin = new System.Windows.Forms.Padding(4);
                    button.Text = "" + i;
                    button.Size = new System.Drawing.Size(140, 31);
                    this.Controls.Add(button);
                }


            }
        }
    }
}
