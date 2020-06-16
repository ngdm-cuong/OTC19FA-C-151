using System;
using SportsBase;
namespace SportsExtend
{
    public class Tenis1 : Team

    {
        #region Private dada fields (instance variables)
        private string fieldLocation;
        private string restringRacketGuy;
        private string coachesName;
        private string starPlayers;
        private int practiceTime;


        #endregion

        #region Public Properties
        public string FieldLocation { get => fieldLocation; set => fieldLocation = value; }
        public string RestringRacketGuy { get => restringRacketGuy; set => restringRacketGuy = value; }
        public string CoachesName { get => coachesName; set => coachesName = value; }
        public string StarPlayers { get => starPlayers; set => starPlayers = value; }
        public int PracticeTime { get => practiceTime; set => practiceTime = value; }


        #endregion
        #region Constructors 

        public Tenis1()
        {
            this.fieldLocation = "Field location";
            this.restringRacketGuy = "restringRacketGuy";
        }

        public Tenis1(global::System.String name, global::System.Int32 numberOfPlayers, global::System.Int32 numberOfcoaches, string fieldLocation, string restringRacketGuy, string coachesName, string starPlayers, int practiceTime)
            : base(name, numberOfPlayers, numberOfcoaches)
        {
            this.fieldLocation = fieldLocation;
            this.restringRacketGuy = restringRacketGuy;
            this.coachesName = coachesName;
            this.starPlayers = starPlayers;
            this.practiceTime = practiceTime;
        }//End of constructor


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
            return returnString;
        }// End of ToString


        #endregion

    }// End of class

}// END OF namespace