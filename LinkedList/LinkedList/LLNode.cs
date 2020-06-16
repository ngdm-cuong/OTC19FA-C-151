using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListHomeWork
{
    class LLNode
    {
        private  LLNode  next;
        private int data;

        public LLNode Next { get => next; set => next = value; }
        public int Data { get => data; set => data = value; }
        public LLNode(int data, LLNode next)
        {
            this.next = null;
            this.data = data;
        }
        public  LLNode() { }
        public LLNode(int data)
        {
            this.next = null;
            this.data = data;
        }

        public void SetData( int d)
        {
            data = d;
        }

        public void SetNext(LLNode n)
        {
            next = n;
        }

        public int GetData()
        {
            return data;
        }
        public LLNode  GetNext()
        {
            return next;
        }
        public override string ToString()
        {
            string result;
            if (next == null)
                result = ($"[{data},Next: null]");
            else
                result = ($"[{data},Next:{next.data}]");
            return (result);
        }
    }// End of class
}// End of namespace
