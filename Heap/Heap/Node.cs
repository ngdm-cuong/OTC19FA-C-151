using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Node
    {
        private string firstName;
        private string lastName;
        private int iDnumber;

        public Node(string lastName)
        {
            this.lastName = lastName;
        }
        public Node() { }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int IDnumber { get => iDnumber; set => iDnumber = value; }

        public override string ToString()
        {
            return lastName;
        }

    }
}
