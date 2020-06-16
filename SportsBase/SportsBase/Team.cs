using System;

namespace SportsBase
{
    /// <summary>
    /// This class define a base Team
    /// Cuong Nguyen
    /// 09/10/2019
    /// </summary>
    public abstract class Team
    {
        #region Private data 
        private string name;
        private int numberOfPlayers;
        private int numberOfcoaches;
        #endregion
        #region Public properties

        public global::System.String Name { get => name; set => name = value; }
        public global::System.Int32 NumberOfPlayers { get => numberOfPlayers; set => numberOfPlayers = value; }
        public global::System.Int32 NumberOfcoaches { get => numberOfcoaches; set => numberOfcoaches = value; }
        #endregion
        #region Constructors
        // No arg constructor
        public Team()
        {
            this.name = "Team Name";
            this.numberOfPlayers = 00;
            this.numberOfcoaches = 00;
        }

        protected Team(global::System.String name, global::System.Int32 numberOfPlayers, global::System.Int32 numberOfcoaches)
        {
            this.name = name;
            this.numberOfPlayers = numberOfPlayers;
            this.numberOfcoaches = numberOfcoaches;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            string returnMessage = "";
            returnMessage += $"Team Name: {name}\n";
            returnMessage += $"Number of players: {numberOfPlayers}\n";
            returnMessage += $"Number of coaches: {numberOfcoaches}\n";
            return returnMessage;
        }// End of ToString method

        public virtual string practicingTimesInWeeks()
        {
            return "Three times a week";
        }
        public abstract string StarPlayer();
        #endregion
    }//End of class
}// END of namespace
