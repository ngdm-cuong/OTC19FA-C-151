using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListHomeWork
{
    class LinkedList
    {
        //private LLNode head;
        private LLNode front;
        private LLNode back;
        private LLNode current;

        internal LLNode Front { get => front; set => front = value; }
        internal LLNode Back { get => back; set => back = value; }
        internal LLNode Current { get => current; set => current = value; }

        public LinkedList(LLNode f, LLNode c, LLNode b)
        {
            this.front = f;
            this.front.Next = c;
            this.current = c;
            this.current.Next = b;
            this.back = b;
        }
        public LinkedList(){ }

        public void SetFront(LLNode data)
        {
            front = data;
            front.Next = current; 
        }

        public void SetCurrent(LLNode data)
        {
            current = data;
            current.Next = back;
        }
        public void SetBack(LLNode data)
        {
            back = data;
            back.Next = null;
        }


        public LLNode GetFront()
        {
            return front;
        }

        public LLNode GetCurrent()
        {
            return current;
        }

        public LLNode GetBack()
        {
            return back;
        }
            public override string ToString()
            {
                string ReturnString;
                ReturnString = $"Front: {front}, \t Current:{current}, \t Back{back}";
                return ReturnString;
            }

    }// End of class
}// End of namespace
