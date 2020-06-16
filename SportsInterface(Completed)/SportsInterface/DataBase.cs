using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsInterface
{
    /// <summary>
    /// generate test data
    /// </summary>
    public class DataBase
    {
        private static Team[] teamList;
        public Team[] TeamList { get; set; }

        public static Team[] BuildData()
        {
            teamList = new Team[20];
            for (int i = 0; i < 10; i++)
            {
                teamList[i] = new Soccer($"Name:{i}", i, i, $"Field Location:{i}", $"Type of shoes:{i}", $"Coaches name: {i}", $"Star players: {i}", i );
  
            }

            for (int i = 10; i < 20; i++)
            {

                teamList[i] = new Tenis($"Name:{i}", i, i, $"Field Location:{i}", $"String Racket guy: {i}", $"Coaches name: {i}", $"Star players: {i}", i);

            }
            return teamList;
        }

    }
}
