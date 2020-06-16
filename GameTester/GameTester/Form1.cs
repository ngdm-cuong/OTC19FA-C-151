using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableTop1App;

namespace GameTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TableTop1 aGame = new TableTop1();
            txtBxOutput.Text = aGame.ToString();
            txtBxOutput.Text += "\r\n----Second Game----\r\n";
            TableTop1 bGame = new TableTop1("Monopoly", "MiltonBradley", new DateTime(1930, 03, 31), 4, 'b', "Board Game", 45);
            txtBxOutput.Text += bGame.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
