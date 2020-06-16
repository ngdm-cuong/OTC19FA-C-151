using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Exam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Play game = new Play();
        Icons[] iconArray = new Icons[3];
        double creditCheck;
        double tempCredit=0;
        double credit = 0;
        double jackPot = 1;
        double winAmount = 0.1;
        double loseAmount =-0.05;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Creating Icons class 
            #region Creating icons class
            btnPlay.Enabled = false;
            for (int i=0; i < iconArray.Length; i++)
            {
                iconArray[i] = new Icons();
                iconArray[i].Image = (Image)(Properties.Resources.ResourceManager.GetObject("rose"));
                iconArray[i].Location = new System.Drawing.Point(100 + (i * 124), 100);
                iconArray[i].Name = "pictureBox" + i;
                iconArray[i].Size = new System.Drawing.Size(100, 100);
                iconArray[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                iconArray[i].TabIndex = 0;
                iconArray[i].TabStop = false;

                this.Controls.Add(iconArray[i]);
            }
            #endregion

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (game.Credit + loseAmount < 0) // Check if you are out of money
            {

                MessageBox.Show("Please bet money!");
                txtBxCredit.Enabled = true;

            }
            else
            {
                // credit = Convert.ToDouble(txtBxCredit.Text);
                txtBxCredit.Enabled = false;

                #region Create 3 icons
                //Loop to initialize icons images into objects
                for (int i = 0; i < iconArray.Length; i++)
                {
                    //Gets the value of the dice
                    iconArray[i].IconValue = Icons.Roll();
                    iconArray[i].Image = (Image)(Properties.Resources.ResourceManager.GetObject("_" + iconArray[i].IconValue));
                    iconArray[i].Location = new System.Drawing.Point(100 + (i * 124), 100);
                    iconArray[i].Name = "pictureBox" + i;
                    iconArray[i].Size = new System.Drawing.Size(100, 100);
                    iconArray[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    iconArray[i].TabIndex = 0;
                    iconArray[i].TabStop = false;

                }
                #endregion
                #region Calculate the credit and show it
                if (iconArray[0].IconValue == iconArray[1].IconValue & iconArray[0].IconValue == iconArray[2].IconValue)
                {
                    lblWinLose.Text = $"YOU WIN ${jackPot}";
                    tempCredit = game.Credit;
                    game.Credit = Math.Round(game.CalCredit(tempCredit, jackPot + loseAmount),2);
                    Console.WriteLine($" Credit {tempCredit} + Changing amount {jackPot + loseAmount} = { game.Credit}"); // For Console debuging
                    lblTotalCredit.Text = $"Total Credit: {game.Credit}";
                    lblTest.Text = game.Credit.ToString();
                    //lblTest.Text = credit.ToString();
                }
                else if (iconArray[0].IconValue == iconArray[1].IconValue || iconArray[1].IconValue == iconArray[2].IconValue || iconArray[0].IconValue == iconArray[2].IconValue)
                {
                    lblWinLose.Text = $"YOU WIN {winAmount * 100} p";
                    tempCredit = game.Credit;
                    game.Credit = Math.Round( game.CalCredit(tempCredit, winAmount + loseAmount),2);
                    Console.WriteLine($" Credit {tempCredit} + Changing amount {winAmount + loseAmount} = { game.Credit}"); // For Console debuging
                    lblTotalCredit.Text = $"Total Credit: {game.Credit}";
                    lblTest.Text = game.Credit.ToString();
                    //lblTest.Text = credit.ToString();
                }
                else
                {
                    lblWinLose.Text = "YOU LOSE";
                    tempCredit = game.Credit;
                    game.Credit = Math.Round(game.CalCredit(tempCredit, loseAmount),2);
                    Console.WriteLine($" Credit {tempCredit} + Changing amount {loseAmount} = { game.Credit}"); // For Console debuging
                    lblTotalCredit.Text = $"Total Credit: {game.Credit}";
                    lblTest.Text = game.Credit.ToString();
                    //lblTest.Text = credit.ToString();
                }
                #endregion
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Purpose : Input value and also check if user enter number 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBxCredit.Text == "0" || txtBxCredit.Text == "" || !double.TryParse(txtBxCredit.Text, out credit))
            {
                // MessageBox.Show("Please bet money!");
                btnPlay.Enabled = false; 
                
            }
            else
            {
                btnPlay.Enabled = true;
                game.Credit = credit;
                lblTest.Text = game.Credit.ToString();
            }

        }
    }
}
