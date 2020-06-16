using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            LLNode ANode = new LLNode(4, null);
            LLNode BNode = new LLNode(1, null);
            LLNode CNode = new LLNode(7, null);
            //LLNode Temp = new LLNode(100);
            LinkedList testList = new LinkedList(ANode, BNode, CNode);
            //testList.SetCurrent(Temp);
            Console.WriteLine($"Front: {testList.GetFront().Data}\t\t Current: {testList.GetCurrent().Data}\t\t Back: {testList.GetBack().Data}");
            Console.WriteLine($"Front: {testList.GetFront()}\t Current: {testList.GetCurrent()}\t Back: {testList.GetBack()}");
            Console.WriteLine();
            Console.WriteLine("front.Next.Data: {0}", ANode.Next);
            Console.WriteLine("current.Next.Data: {0}", BNode.Next);
            Console.ReadKey();

        }
    }//End of Main class
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

        public LinkedList(LLNode f, LLNode c, LLNode b)
        {
            this.front = f;
            this.front.Next = c;
            this.current = c;
            this.current.Next = b;
            this.back = b;
        }
        public LinkedList() { }

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

    }// End of class
}//End of Namespace
