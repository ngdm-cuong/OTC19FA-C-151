using System;
//using SportsBase;
namespace SportsInterface
{
    public class Soccer : Team, iAnnualBudget

    {
        #region Private dada fields (instance variables)
        private string fieldLocation;
        private string typeOfShose;
        private string coachesName;
        private string starPlayers;
        private int practiceTime;


        #endregion

        #region Public Properties
        public string FieldLocation { get => fieldLocation; set => fieldLocation = value; }
        public string TypeOfShose { get => typeOfShose; set => typeOfShose = value; }
        public string CoachesName { get => coachesName; set => coachesName = value; }
        public string StarPlayers { get => starPlayers; set => starPlayers = value; }
        public int PracticeTime { get => practiceTime; set => practiceTime = value; }


        #endregion
        #region Constructors 

        public Soccer()
        {
            this.fieldLocation = "Field location";
            this.typeOfShose = "Type of shoose";
        }

        public Soccer(global::System.String name, global::System.Int32 numberOfPlayers, global::System.Int32 numberOfcoaches, string fieldLocation, string typeOfShose,  string coachesName, string starPlayers, int practiceTime)
            : base(name, numberOfPlayers, numberOfcoaches)
        {
            this.fieldLocation = fieldLocation;
            this.typeOfShose = typeOfShose;
            this.coachesName = coachesName;
            this.starPlayers = starPlayers;
            this.practiceTime = practiceTime;
        }


        #endregion
        #region Methods
        /// <summary>
        /// Display the star players of the team
        /// </summary>
        /// <returns></returns>
        public override string StarPlayer()
        {
            return $"Star Players: {starPlayers}";
        }//End of StarPlayer
        /// <summary>
        /// Return a string value of an instance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string returnString = base.ToString();
            returnString += $"Coaches Name: {coachesName}";
            returnString += $"Practicing frequencies: {practiceTime} per Week";
            returnString += $"Type of Shoose: {typeOfShose}";
            return returnString;
        }// End of ToString
        /// <summary>
        /// Implement budget method from interface
        /// </summary>
        /// <returns></returns>
        public int  budget()
        {
            int food = 10;
            int gas = 10;
            int numPeople;
            numPeople = this.NumberOfcoaches + this.NumberOfPlayers;
            int gamesInYear = 5;
            return ((food + gas)*numPeople*gamesInYear);

        }


        #endregion
   
    }// End of class

}// END OF namespace