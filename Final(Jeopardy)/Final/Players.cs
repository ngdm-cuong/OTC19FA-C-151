using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Players
    {
        private string playerName;
        private int score;
        public static Players[] PlayersArray = new Players[3];
        #region Public Properties
        public string PlayerName { get => playerName; set => playerName = value; }
        public int Score { get => score; set => score = value; }
        #endregion

        #region Constructors
        //Default Constructor
        public Players(){}
        public Players(string playerName, int score)
        {
            this.playerName = playerName;
            this.score = score;
        }
        #endregion

        public override string ToString()
        {
            return playerName;
        }

    }// END OF CLASS
}//END OF NAMESPACE
