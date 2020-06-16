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

namespace _11EmployeePart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DataAdapter.Connect();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataAdapter.Get();
            listBox1.Items.Add("Testing");
            foreach (FullTime item in DataAdapter.FullTimeEmployees)
            {
                listBox1.Items.Add(item);
                //Console.WriteLine(item);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DataAdapter.Disconnect();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
