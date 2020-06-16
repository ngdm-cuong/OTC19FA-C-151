using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frmOption : Form
    {
        int playeridx = 0;

        public frmOption()
        {
            InitializeComponent();
            nUDnumofPlayers.Maximum = 3;
            nUDnumofPlayers.Minimum = 1;
        }

        private void FrmOption_Load(object sender, EventArgs e)
        {
            this.Activate();
        }
        private void BtnGo_Click(object sender, EventArgs e)
        {
            nUDnumofPlayers.Visible = false;
            lblNumofPlayers.Visible = false;
            btnGo.Visible = false;
            btnOK.Visible = true;
            lblPlayerName.Visible = true;
            lblPlayerName.Text = $"Player {playeridx + 1} name:";
            txtPlayerName.Visible = true;

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            if (playeridx < nUDnumofPlayers.Value)
            {
                Players aPlayer = new Players(txtPlayerName.Text, 0);
                Players.PlayersArray[playeridx] = aPlayer;
                txtPlayerName.Clear();
                if(playeridx + 1 == nUDnumofPlayers.Value)
                {
                    btnGo.Visible = false;
                    btnOK.Visible = false;
                    lblPlayerName.Visible = false;
                    txtPlayerName.Visible = false;
                    btnStart.Visible = true;
                    return;
                }
                else
                {
                    playeridx++;
                    lblPlayerName.Text = $"Player {playeridx + 1} name:";
                }
            }        
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    base.OnFormClosing(e);

        //    if (e.CloseReason == CloseReason.WindowsShutDown) return;

        //    // Confirm user wants to close
        //    switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
        //    {
        //        case DialogResult.No:
        //            e.Cancel = true;
        //            break;
        //        case DialogResult.Yes:
        //            Application.Exit();
        //            break;
        //    }
        //}

    }
}
