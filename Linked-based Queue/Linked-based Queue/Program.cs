using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_based_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            LLNode ANode = new LLNode(4, null);
            LLNode BNode = new LLNode(1, null);
            LLNode CNode = new LLNode(7, null);
            LLNode DNode = new LLNode(3, null);
            LLNode ENode = new LLNode(5, null);
            LLNode FNode = new LLNode(0, null);
            //LLNode Temp = new LLNode(100);
            //testList.SetCurrent(Temp);
            LinkedQueue testQueue = new LinkedQueue();
            Console.WriteLine("Linked based queue assignment.");
            testQueue.Dequeue(); // TESTING on dequeue when the queue is empty
            Console.WriteLine("Enqueue Node A");
            testQueue.Enqueue(ANode);
            Console.WriteLine("Enqueue Node B");
            testQueue.Enqueue(BNode);
            testQueue.Peek();
            Console.WriteLine("Enqueue Node C");
            testQueue.Enqueue(CNode);
            Console.WriteLine("Enqueue Node D");
            testQueue.Enqueue(DNode);

            testQueue.PrintQueue();
            Console.WriteLine("######################################");
            testQueue.Dequeue();
            testQueue.Peek();
            testQueue.Dequeue();
            testQueue.Dequeue();
            testQueue.Dequeue();
            testQueue.Peek();
            Console.ReadKey();

        }
    }//End of Main class

    #region Other Classes
    class LLNode
    {
        private LLNode next;
        private int data;

        public LLNode Next { get => next; set => next = value; }
        public int Data { get => data; set => data = value; }
        public LLNode(int data, LLNode next)
        {
            this.next = null;
            this.data = data;
        }
        public LLNode() { }
        public LLNode(int data)
        {
            this.next = null;
            this.data = data;
        }

        public void SetData(int d)
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
        public LLNode GetNext()
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
    class LinkedList
    {
        //private LLNode head;
        private LLNode front;
        private LLNode back;
        private LLNode current;

        internal LLNode Front { get => front; set => front = value; }
        internal LLNode Back { get => back; set => back = value; }
        internal LLNode Current { get => current; set => current = value; }
        public LinkedList() { }

        public LinkedList(LLNode front, LLNode back, LLNode current)
        {
            this.front = front;
            this.back = back;
            this.Current = current;
        }

        public void SetFront(LLNode data)
        {
            front = data;
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

        public LLNode GetBack()
        {
            return back;
        }
        public override string ToString()
        {
            string ReturnString;
            if (front == null)
                ReturnString = ("The queue is empty");
            else
                ReturnString = $"Front: {front}, \t Back{back}";
            return ReturnString;
        }

    }// End of class
    class LinkedQueue
    {
        LinkedList list = new LinkedList();
        private static int count = 0;

        public LinkedQueue() { }

        internal LinkedList Item { get => list; set => list = value; }

        public void Enqueue(LLNode item)
        {
            if (count ==0)
            {
                list.Front = item;
                list.Back = item;
                count++;
            }
            else
            {
                list.Back.Next =item;
                list.Back = item;
                count++;
            }
            Console.WriteLine("Queue: {0}", list);
        }
        public void Dequeue()
        {
            Console.WriteLine("Dequeue");
            if (count > 0)
            {
                list.Front = list.Front.Next;
                count--;
            }
            else
            {
                list.Front = null;
                list.Back = null;
                Console.WriteLine("Cannot Dequeue because the queue is empty");
            }
            Console.WriteLine("Queue: {0}", list);

        }
        public LLNode Peek()
        {
            LLNode Result = new LLNode();
            if(list.Front != null)
            {
                Result = list.Front;
                Console.WriteLine("Peek: {0}", Result);
            }
            else
            {
                Result = list.Front;
                Console.WriteLine("Peek: Null");
            }


            return Result;
        }
        public override string ToString()
        {
            string ReturnString;
            if (list.Front == null)
                ReturnString=("The queue is empty");
            else
                ReturnString = $"Front: {list.Front}, \t Back{list.Back}";
            return ReturnString;
        }
        public void PrintQueue()
        {
            list.Current = list.Front;
            while (list.Current!=null)
            {               
                Console.Write(list.Current);
                list.Current = list.Current.Next;
            }
            Console.WriteLine();
        }

    }
    #endregion

}//End of Namespace


