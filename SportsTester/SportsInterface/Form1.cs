using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SportsTester
{
    public partial class Form1 : Form
    {
        Team[] teamList = new Team[100];
        int currentRow;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            teamList = DataBase.BuildData();
            foreach (var item in teamList)
            {
                if (item is Soccer)
                {
                    Soccer gameItem = (Soccer)item;
                    lstBxOutPut.Items.Add(item);
                } // end if
                else
                {
                    lstBxOutPut.Items.Add(item);
                } // end else

            }  // end foreach
            EnDisFields(false);
        }
        public void EnDisFields(bool action)
        {
            this.txtBxName.Enabled = action;
            this.numericUpDownPlayers.Enabled = action;
            this.numericUpDowCoaches.Enabled = action;
            this.txtBxStarPlayers.Enabled = action;
            this.numericUpDownPractice.Enabled = action;

            this.txtBxCoachName.Enabled = action;
            this.txtBxShoes.Enabled = action;
            this.txtBxStringRacket.Enabled = action;

        }
        private void lstBxOutPut_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentRow = lstBxOutPut.SelectedIndex;
            Team item = (Team)lstBxOutPut.SelectedItem;
            if (item is Soccer)
            {
                Soccer soccerTeam = (Soccer)item;
                LoadTeamData(soccerTeam);
                LoadSocer(soccerTeam);

            }
            else
            {
                Tenis tenisTeam = (Tenis)item;
                LoadTeamData(tenisTeam);
                LoadTenis(tenisTeam);
            }

        }

        private void LoadTeamData(Team item)
        {
            txtBxName.Text = item.Name;
            numericUpDownPlayers.Value = item.NumberOfPlayers;
            numericUpDowCoaches.Value = item.NumberOfcoaches;
      


        }

        private void LoadSocer(Soccer item)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            txtBxStarPlayers.Text = item.StarPlayers;
            txtBxCoachName.Text = item.CoachesName;
            txtBxShoes.Text = item.TypeOfShose;
            numericUpDownPractice.Value = item.PracticeTime;

        }
        private void LoadTenis(Tenis item)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            txtBxStarPlayers.Text = item.StarPlayers;
            txtBxCoachName.Text = item.CoachesName;
            txtBxStringRacket.Text = item.RestringRacketGuy;
            numericUpDownPractice.Value = item.PracticeTime;

        }
        /// <summary>
        /// add a new row to the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: Add code to add a new game object to the array and list

            // set current row to zero
            currentRow = 0;
            ClearForm();
            EnDisFields(true);

            // validate form data

            // use form data to create a new instance

            // add the new instance to the list box

        } // end of method
        /// <summary>
        /// update the current row with new form data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // TODO: Add code to update the current row

            // validate form data

            // use form data to update the game instance

            // update the game instance in the listbox
        }
        /// <summary>
        /// delete the selected row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Add code to delete the current row
        }
        private void ClearForm()
        {
            txtBxName.Clear();
            numericUpDownPlayers.Value = 0 ;
            numericUpDowCoaches.Value = 0;
            txtBxStarPlayers.Clear() ;
            numericUpDownPractice.Value = 0;

            txtBxCoachName.Clear() ;
            txtBxShoes.Clear() ;
            txtBxStringRacket.Clear() ;

        }

    }

}
