using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    class Question : Button
    {
        private int point;
        private string answer;
        private string trivia;

        public int Point { get => point; set => point = value; }
        public string Answer { get => answer; set => answer = value; }
        public string Trivia { get => trivia; set => trivia = value; }

        public Question (){}
    }
}
