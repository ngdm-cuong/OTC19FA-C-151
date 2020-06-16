using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frmAandQ : Form
    {
        private int quick = 900;
        public int ReturnPoint { get; set; }
        public bool ReturnBool { get; set; }
        Question aQuestion = new Question();
        public frmAandQ(object sender)
        {
            InitializeComponent();
            aQuestion = (Question)sender;
            txtBxQuestion.Text = aQuestion.Trivia;
            //lblQuestion.Text = aQuestion.Trivia;
        }

        private void FrmAandQ_Load(object sender, EventArgs e)
        {
            TimerCountDown = new System.Windows.Forms.Timer();
            TimerCountDown.Interval = 1; // For 1 second interval
            TimerCountDown.Tick += new EventHandler(TimerCountDown_Tick);
            TimerCountDown.Enabled = true;
            this.ActiveControl = txtBxAnswer;

            //Question b = (Question)sender;
            //txtBxQuestion.Text = b.Trivia;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TimerCountDown.Stop();

            if ( txtBxAnswer.Text.ToLower() == aQuestion.Answer.ToLower())
            {
                this.ReturnBool = true;
                this.ReturnPoint = aQuestion.Point;
                this.DialogResult = DialogResult.OK;
                string message = "Correct";
                string title = "Congratulation";
                MessageBox.Show(message, title);
                this.Close();
            }
            else
            {
                this.ReturnBool = false;
                this.ReturnPoint = aQuestion.Point * -1;
                this.DialogResult = DialogResult.OK;
                string message = $"Oops!!! The correct answer is {aQuestion.Answer}";
                string title = "Oops";
                MessageBox.Show(message, title);
                this.Close();
            }
        }

        /// <summary>
        /// Timercountdown , not sure if you want the question to be closed or the player still have chance to answer after that 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerCountDown_Tick(object sender, EventArgs e)
        {
            if (quick > 0)
            {
                // by updating the Time Left label.
                quick--;
                lblTimer.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
                
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                TimerCountDown.Stop();
                string message = $"Time's up!!!\nThe correct answer is \"{aQuestion.Answer}\"";
                string title = "Oops! Time's up.";
                MessageBox.Show(message, title);
                this.Close();// Im not sure if you want to close the form

            }

        }

        private void FrmAandQ_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerCountDown.Stop();
        }
    }
}
