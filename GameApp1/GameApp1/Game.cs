using System;

namespace GameApp
{
    /// <summary>
    /// This class defines a base game 
    /// Cuong Nguyen
    /// </summary>
    /// Distribution methods:
    /// U = Unknown
    /// E = Online
    /// e = Online Exclusive
    /// B = Brick & Mortar
    public abstract class Game
    {
        #region Private class fields (instance variables)
        private string name;
        private string developer;
        private DateTime dayReleased;
        private int version;
        private char distribution;
        #endregion
        #region Public properties
        public string Name { get => name; set => name = value; }
        public string Developer { get => developer; set => developer = value; }
        public DateTime DayReleased { get => dayReleased; set => dayReleased = value; }
        public int Version { get => version; set => version = value; }
        public char Distribution { get => distribution; set => distribution = value; }
        #endregion
        #region Constructors
        /// <summary>
        /// fullypopulated game instance
        /// </summary>
        /// <param name="name"></param>
        /// <param name="developer"></param>
        /// <param name="dateReleased"></param>
        /// <param name="version"></param>
        /// <param name="distribution"></param>
        public Game(string name, string developer, DateTime dateReleased, int version, char distribution)
        {
            this.name = name;
            this.developer = developer;
            this.dayReleased = dateReleased;
            this.version = version;
            this.distribution = distribution;
        } // end of constructor
        #endregion

        public Game()
        {
            this.name = "The Game";
            this.developer = "FedEx& UPS";
            this.dayReleased = new DateTime(2019, 01, 01);
            this.version = 0;
            //this.distribution = ;
        }
        #region Methods for the instance
        /// <summary>
        /// ToStrong override to display game as a string
        /// </summary>
        /// <returns>returnString</returns>
        public override string ToString()
        {
            string returnString = "";
            returnString += $"Name {name}\r\n";
            returnString += $"Developer {developer}\r\n";
            returnString += $"Date Released {dayReleased}\r\n";
            returnString += $"Version {version}\r\n";
            returnString += $"Distribution {distribution}\r\n";
            return returnString;

        }

        public virtual string DisplayMSRP()
        {
            // virtual methodhas a body in the bse class
            //can be overriden by derived classes (optional)
            return "efault base MSRP";
        }//end of DisplayMSRP

        /// <summary>
        /// method to return a summary of the game
        /// </summary>
        /// <returns></returns>
        public abstract string Displaysummary();

        #endregion

    }//end of class
} //end of solution 
