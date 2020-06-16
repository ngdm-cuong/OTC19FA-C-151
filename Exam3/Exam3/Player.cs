using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Player
    {
        private string name;
        private int strengths;

        public string Name { get => name; set => name = value; }
        public int Strengths { get => strengths; set => strengths = value; }
        /// <summary>
        /// Construction 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="strengths"></param>
        public Player(string name, int strengths)
        {
            this.name = name;
            this.strengths = strengths;
        }

        // Instance
        /// <summary>
        /// 
        /// </summary>
        public Player()
        {
            this.name = "Player's name";
            this.strengths = 0;
        }
        /// <summary>
        /// over ride string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string message = "";
            message += $"{name}\t\t";
            message += $"{strengths}\n";
            return message;
        }

    }
}
