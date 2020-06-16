using System;
using GameApp;

namespace TableTop1App
{
    public class TableTop1 : Game
    {
        #region Private data fields (instance variables)
        private string format;
        private int maxNoPlayers;
        #endregion end Private data fields
        #region Public Properties
        public string Format { get => format; set => format = value; }
        public int MaxNoPlayers { get => maxNoPlayers; set => maxNoPlayers = value; }
        #endregion end Public Properties

        #region Constructors

        /// <summary>
        /// fully populated constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="developer"></param>
        /// <param name="dateReleased"></param>
        /// <param name="version"></param>
        /// <param name="distribution"></param>
        /// <param name="format"></param>
        /// <param name="maxNoPlayers"></param>
        public TableTop1(string name, string developer, DateTime dateReleased, int version, char distribution,
            string format, int maxNoPlayers)
            : base(name, developer, dateReleased, version, distribution)
        {
            this.format = format;
            this.maxNoPlayers = maxNoPlayers;
        } // end constructor

        /// <summary>
        /// default no arg constructor
        /// </summary>
        public TableTop1()
        {
            this.format = "Format";
            this.maxNoPlayers = 99;
        } // end constructor
        #endregion end Constructors
        #region Methods
        /// <summary>
        /// display a summary of the game
        /// </summary>
        /// <returns></returns>
        public override string Displaysummary()         // override an abstract method
        {
            return $"This game is {format}";
        } // end of DisplaySummary

        /// <summary>
        /// display the msrp of the game
        /// </summary>
        /// <returns></returns>
        public override string DisplayMSRP()            // override a virtual method
        {
            return "How do I know this? Do I need a data field?";
        }
        /// <summary>
        /// return a string value of the current instance
        /// </summary>
        /// <returns></returns>
        public override string ToString()               // override a system virtual method
        {
            string returnString = base.ToString();
            returnString += $"Format {format}\r\n";
            returnString += $"Max Players {maxNoPlayers}\r\n";
            return returnString;
        } // end of ToString method
        #endregion end of Methods
    }
}
