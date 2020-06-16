using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListHomeWork
{
    class LinkedQueue
    {
        LinkedList list;

        public LinkedQueue(LinkedList list)
        {
            this.list = list;
        }

        internal LinkedList Item { get => list; set => list = value; }

        public void Enqueue(LinkedList item)
        {

        }
        public void Dequeue()
        {
            LLNode temp;
            temp = list.GetBack();
            list.Front = list.GetCurrent();
            list.Current = temp;
            list.Back = null;
        }
        public void Peek(LinkedList item)
        {

        }
    }
}
